using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    public abstract class NewsSource : INewsSource
    {
        public abstract Task<IEnumerable<News>> GetNews(Func<News, bool> condition);
    }
}
