using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    public class PressTrustOfIndiaNewsSource : NewsSource
    {
        public override Task<IEnumerable<News>> GetNews(Func<News, bool> condition)
        {
            throw new NotImplementedException();
        }
    }
}
