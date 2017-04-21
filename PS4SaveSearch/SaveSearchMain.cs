using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Be.Windows.Forms;
using BrightIdeasSoftware;
using PS4SaveSearch.Properties;

namespace PS4SaveSearch
{
    /// <summary>
    /// Main form class supporting the "PS4 Save Search" Tool
    /// </summary>
    public partial class SaveSearchMain : Form
    {
        private int _iteration;
        private int _searchValue;
        private byte[] _saveFileByteArray;
        private int _index;
        private List<SearchResult> _searchResults;
        private List<SearchResult> _incSearchResults;
        private Boolean _initialSearch;
 
        /// <summary>
        /// Initialise the components and main local properties
        /// </summary>
        public SaveSearchMain()
        {
            InitializeComponent();
            _searchResults = new List<SearchResult>();
            _incSearchResults = new List<SearchResult>();
            _initialSearch = true;
            _index = 1;
            searchTypeComboBox.SelectedIndex = 0;
            this.Icon = Properties.Resources.picture_find32x32;
        }

        /// <summary>
        /// Handle the "Open Save" button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openSaveButton_Click(object sender, EventArgs e)
        {
            OpenSave();
        }

        /// <summary>
        /// Main function to open and process the save file
        /// </summary>
        private void OpenSave()
        {
            // Show the dialog and continue if a file is picked
            if (openSaveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Populate the Log File name
                String filePath = openSaveFile.FileName;
                saveFileTextBox.Text = filePath;
                var dynamicFileByteProvider = new DynamicFileByteProvider(filePath, true);

                saveFileHexBox.ByteProvider = dynamicFileByteProvider;
                _saveFileByteArray = File.ReadAllBytes(filePath);
            }
        }

        /// <summary>
        /// Handle the search button click. Work out if initial search or incremental search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Get search values
            InitSearch();

            // Determine if initial search or incremental search and execute appropriate function
            if (_initialSearch)
            {
                Search();
            }
            else
            {
                IncrementalSearch();    
            }

        }

        /// <summary>
        /// Initialise the search options
        /// </summary>
        private void InitSearch()
        {
            _searchValue = (int)searchValueUpDown.Value;
        }

        /// <summary>
        /// Perform the initial search in memory and record address locations in local listview
        /// </summary>
        private void Search()
        {
            byte[] pattern = BitConverter.GetBytes(_searchValue);
            int patternLength = pattern.Length;
            int totalLength = _saveFileByteArray.Length;
            byte firstMatchByte = pattern[0];
            for (int currAddress = 0; currAddress < totalLength; currAddress++)
            {
                if (firstMatchByte == _saveFileByteArray[currAddress] && totalLength - currAddress >= patternLength)
                {
                    byte[] match = new byte[patternLength];
                    Array.Copy(_saveFileByteArray, currAddress, match, 0, patternLength);
                    if (match.SequenceEqual<byte>(pattern))
                    {
                        // Add the result to the list of search results
                        AddResult(_searchResults, _index, currAddress, _searchValue.ToString());
                        _index++;
                        currAddress += patternLength - 1;
                    }
                }
            }
        
            // Update the object list view
            searchResultsListView.SetObjects(_searchResults);
            _iteration++;
            iterationUpDown.Value = _iteration;

            // Ensure subsequent search is incremental
            _initialSearch = false;
            searchButton.Text = "Search again";
        }

        /// <summary>
        /// Perform the incremental search
        /// </summary>
        private void IncrementalSearch()
        {
            byte[] pattern = BitConverter.GetBytes(_searchValue);
            int patternLength = pattern.Length;
            int totalLength = _saveFileByteArray.Length;
            byte firstMatchByte = pattern[0];
            _incSearchResults = new List<SearchResult>();

            for (int currAddress = 0; currAddress < totalLength; currAddress++)
            {
                if (firstMatchByte == _saveFileByteArray[currAddress] && totalLength - currAddress >= patternLength)
                {
                    byte[] match = new byte[patternLength];
                    Array.Copy(_saveFileByteArray, currAddress, match, 0, patternLength);
                    if (match.SequenceEqual<byte>(pattern))
                    {
                        // int foundIndex = FindInList(currAddress);
                        // if (foundIndex != -1)
                        // {
                        // AddResult(_incSearchResults, _index, currAddress, _searchValue.ToString());
                        AddResult(_searchResults, _index, currAddress, _searchValue.ToString());
                        // }
                        currAddress += patternLength - 1;
                    }
                }
            }

            // _searchResults = _incSearchResults;
            searchResultsListView.SetObjects(_searchResults);
            _iteration++;
            iterationUpDown.Value = _iteration;
            searchResultsListView.Sort(olvAddress);
        }

        /// <summary>
        /// Add a result to the SearchResults list
        /// </summary>
        /// <param name="results"></param>
        /// <param name="index"></param>
        /// <param name="addressOffset"></param>
        /// <param name="value"></param>
        private void AddResult(List<SearchResult> results, int index, int addressOffset, String value)
        {
            SearchResult result = new SearchResult(index, addressOffset, value, _iteration);
            results.Add(result);
        }

        /// <summary>
        /// Checks if incremental address found in list. If so, return the index
        /// </summary>
        /// <param name="addressOffset"></param>
        /// <returns></returns>
        private int FindInList(int addressOffset)
        {
            SearchResult search = _searchResults.Find(x => x.AddressOffset == addressOffset);
            if (search != null)
            {
                return search.ResultIndex;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Reset the search back to initial state
        /// </summary>
        private void Reset()
        {
            _iteration = 0;
            _index = 1;
            iterationUpDown.Value = 0;
            _searchResults = new List<SearchResult>();
            searchResultsListView.ClearObjects();
            _initialSearch = true;
            searchButton.Text = "Search";
        }

        /// <summary>
        /// Handle clicking of the search results. Set selection focus on HexBox address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchResultsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectListView olv = (ObjectListView)sender;
            SearchResult result = (SearchResult)olv.SelectedObject;
            if (result != null)
            {
                GotoAddress(result);
            }
        }

        /// <summary>
        /// Go to the address specified in the SearchResult object address integer value
        /// </summary>
        /// <param name="result"></param>
        private void GotoAddress (SearchResult result)
        {
            String address = result.Address;
            int offSet = int.Parse(address, System.Globalization.NumberStyles.HexNumber);

            saveFileHexBox.SelectionStart = offSet;
        }

        /// <summary>
        /// Handle the reset button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
