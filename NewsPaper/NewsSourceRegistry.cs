using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    public class NewsSourceRegistry : INewsSourceRegistry
    {
        private List<INewsSource> _newsSourceList = new List<INewsSource>();
        
        public async Task Register(INewsSource newsSource)
        {
          _newsSourceList.Add(newsSource);
        }


        public async Task<IEnumerable<News>> GetAllRegisteredNews()
        {
            List<News> newsList = new List<News>();
            foreach (var news in _newsSourceList)
            {
                newsList.AddRange(news.GetNews(x=>x.CreatedAt >= DateTime.UtcNow.AddDays(-1)).Result);
            }

            return await Task.FromResult(newsList.AsEnumerable());
        }
    }
}
