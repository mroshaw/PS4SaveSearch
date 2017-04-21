using System;

namespace PS4SaveSearch
{
    class SearchResult
    {
        public int ResultIndex { get; set; }
        public String Address { get; set; }
        public int AddressOffset {get; set;}
        public String Value { get; set; }
        public int Iteration { get; set; }

        public SearchResult (int resultIndex, int addressOffset, String value, int iteration)
        {
            ResultIndex = resultIndex;
            AddressOffset = addressOffset;
            Address = addressOffset.ToString("X8");
            Value = value;
            Iteration = iteration;
        }
    }
}
