using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    public interface INewsSource
    {
        Task<IEnumerable<News>> GetNews(Func<News, bool> condition);
    }
}
