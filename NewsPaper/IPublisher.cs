using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    public interface IPublisher
    {
        Task<IEnumerable<News>> Publish(int pageNumber);
    }
}
