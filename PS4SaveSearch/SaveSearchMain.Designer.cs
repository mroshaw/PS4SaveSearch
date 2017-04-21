namespace PS4SaveSearch
{
    partial class SaveSearchMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openSaveFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileTextBox = new System.Windows.Forms.TextBox();
            this.openSaveButton = new System.Windows.Forms.Button();
            this.saveFileHexBox = new Be.Windows.Forms.HexBox();
            this.searchResultsListView = new BrightIdeasSoftware.ObjectListView();
            this.olvResultIndex = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvIteration = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchValueLabel = new System.Windows.Forms.Label();
            this.iterationUpDown = new System.Windows.Forms.NumericUpDown();
            this.searchValueUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchValueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // openSaveFile
            // 
            this.openSaveFile.FileName = "openSaveFile";
            // 
            // saveFileTextBox
            // 
            this.saveFileTextBox.Location = new System.Drawing.Point(57, 14);
            this.saveFileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveFileTextBox.Name = "saveFileTextBox";
            this.saveFileTextBox.Size = new System.Drawing.Size(523, 22);
            this.saveFileTextBox.TabIndex = 0;
            // 
            // openSaveButton
            // 
            this.openSaveButton.Location = new System.Drawing.Point(585, 14);
            this.openSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openSaveButton.Name = "openSaveButton";
            this.openSaveButton.Size = new System.Drawing.Size(75, 25);
            this.openSaveButton.TabIndex = 1;
            this.openSaveButton.Text = "...";
            this.openSaveButton.UseVisualStyleBackColor = true;
            this.openSaveButton.Click += new System.EventHandler(this.openSaveButton_Click);
            // 
            // saveFileHexBox
            // 
            this.saveFileHexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFileHexBox.ColumnInfoVisible = true;
            this.saveFileHexBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveFileHexBox.LineInfoVisible = true;
            this.saveFileHexBox.Location = new System.Drawing.Point(12, 41);
            this.saveFileHexBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveFileHexBox.Name = "saveFileHexBox";
            this.saveFileHexBox.ReadOnly = true;
            this.saveFileHexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.saveFileHexBox.Size = new System.Drawing.Size(685, 463);
            this.saveFileHexBox.StringViewVisible = true;
            this.saveFileHexBox.TabIndex = 2;
            this.saveFileHexBox.VScrollBarVisible = true;
            // 
            // searchResultsListView
            // 
            this.searchResultsListView.AllColumns.Add(this.olvResultIndex);
            this.searchResultsListView.AllColumns.Add(this.olvAddress);
            this.searchResultsListView.AllColumns.Add(this.olvValue);
            this.searchResultsListView.AllColumns.Add(this.olvIteration);
            this.searchResultsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultsListView.CellEditUseWholeCell = false;
            this.searchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvResultIndex,
            this.olvAddress,
            this.olvValue,
            this.olvIteration});
            this.searchResultsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchResultsListView.FullRowSelect = true;
            this.searchResultsListView.GridLines = true;
            this.searchResultsListView.Location = new System.Drawing.Point(701, 71);
            this.searchResultsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchResultsListView.Name = "searchResultsListView";
            this.searchResultsListView.ShowGroups = false;
            this.searchResultsListView.Size = new System.Drawing.Size(345, 430);
            this.searchResultsListView.TabIndex = 4;
            this.searchResultsListView.UseCompatibleStateImageBehavior = false;
            this.searchResultsListView.View = System.Windows.Forms.View.Details;
            this.searchResultsListView.SelectedIndexChanged += new System.EventHandler(this.searchResultsListView_SelectedIndexChanged);
            // 
            // olvResultIndex
            // 
            this.olvResultIndex.AspectName = "ResultIndex";
            this.olvResultIndex.Text = "#";
            this.olvResultIndex.Width = 35;
            // 
            // olvAddress
            // 
            this.olvAddress.AspectName = "Address";
            this.olvAddress.Text = "Address";
            this.olvAddress.Width = 100;
            // 
            // olvValue
            // 
            this.olvValue.AspectName = "Value";
            this.olvValue.Text = "Value";
            // 
            // olvIteration
            // 
            this.olvIteration.AspectName = "Iteration";
            this.olvIteration.Text = "Iteration";
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Items.AddRange(new object[] {
            "Int",
            "Hex",
            "Str"});
            this.searchTypeComboBox.Location = new System.Drawing.Point(862, 41);
            this.searchTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(75, 24);
            this.searchTypeComboBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(943, 41);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 27);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // iterationLabel
            // 
            this.iterationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Location = new System.Drawing.Point(701, 12);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(59, 17);
            this.iterationLabel.TabIndex = 8;
            this.iterationLabel.Text = "Iteration";
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(862, 12);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 25);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // searchValueLabel
            // 
            this.searchValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchValueLabel.AutoSize = true;
            this.searchValueLabel.Location = new System.Drawing.Point(701, 44);
            this.searchValueLabel.Name = "searchValueLabel";
            this.searchValueLabel.Size = new System.Drawing.Size(44, 17);
            this.searchValueLabel.TabIndex = 10;
            this.searchValueLabel.Text = "Value";
            // 
            // iterationUpDown
            // 
            this.iterationUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iterationUpDown.Location = new System.Drawing.Point(765, 12);
            this.iterationUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iterationUpDown.Name = "iterationUpDown";
            this.iterationUpDown.ReadOnly = true;
            this.iterationUpDown.Size = new System.Drawing.Size(92, 22);
            this.iterationUpDown.TabIndex = 11;
            // 
            // searchValueUpDown
            // 
            this.searchValueUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchValueUpDown.Location = new System.Drawing.Point(765, 43);
            this.searchValueUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchValueUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.searchValueUpDown.Name = "searchValueUpDown";
            this.searchValueUpDown.Size = new System.Drawing.Size(92, 22);
            this.searchValueUpDown.TabIndex = 12;
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(8, 18);
            this.saveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(40, 17);
            this.saveLabel.TabIndex = 13;
            this.saveLabel.Text = "Save";
            // 
            // SaveSearchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 516);
            this.Controls.Add(this.saveLabel);
            this.Controls.Add(this.searchValueUpDown);
            this.Controls.Add(this.iterationUpDown);
            this.Controls.Add(this.searchValueLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.iterationLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTypeComboBox);
            this.Controls.Add(this.searchResultsListView);
            this.Controls.Add(this.saveFileHexBox);
            this.Controls.Add(this.openSaveButton);
            this.Controls.Add(this.saveFileTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SaveSearchMain";
            this.Text = "PS4 Save Search";
            ((System.ComponentModel.ISupportInitialize)(this.searchResultsListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchValueUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openSaveFile;
        private System.Windows.Forms.TextBox saveFileTextBox;
        private System.Windows.Forms.Button openSaveButton;
        private Be.Windows.Forms.HexBox saveFileHexBox;
        private BrightIdeasSoftware.ObjectListView searchResultsListView;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.Button searchButton;
        private BrightIdeasSoftware.OLVColumn olvResultIndex;
        private BrightIdeasSoftware.OLVColumn olvAddress;
        private BrightIdeasSoftware.OLVColumn olvValue;
        private BrightIdeasSoftware.OLVColumn olvIteration;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label searchValueLabel;
        private System.Windows.Forms.NumericUpDown iterationUpDown;
        private System.Windows.Forms.NumericUpDown searchValueUpDown;
        private System.Windows.Forms.Label saveLabel;
    }
}

