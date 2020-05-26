using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPaper
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string[] ImageUrls { get; set; }
        //public INewsSource NewsSource { get; set; }
        public bool IsBreaking { get; set; }
        public int Priority { get; set; }
        public NewsCategory Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
