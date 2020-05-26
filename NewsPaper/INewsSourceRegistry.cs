using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsPaper
{
    public interface INewsSourceRegistry
    {
        Task Register(INewsSource newsSource);
        Task<IEnumerable<News>> GetAllRegisteredNews();
    }
}
