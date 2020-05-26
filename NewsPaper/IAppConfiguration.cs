using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPaper
{
    public interface IAppConfiguration
    {
        int MaxItemsPerPage { get; set; }
        float AdRatioPerPage { get; set; }

        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int ActualPage { get; set; }
        public int TotalPages { get; set; }
        public string Previous { get; set; }
        public string Next { get; set; }
    }
}
