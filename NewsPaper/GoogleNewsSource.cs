using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    public class GoogleNewsSource : NewsSource
    {
        public override Task<IEnumerable<News>> GetNews(Func<News, bool> condition)
        {
            throw new NotImplementedException();
        }
    }
}
