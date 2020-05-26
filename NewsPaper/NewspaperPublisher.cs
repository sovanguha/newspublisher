using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPaper
{
    public class NewspaperPublisher : IPublisher
    {
        private readonly INewsSourceRegistry _newsSourceRegistery;
        private readonly IAppConfiguration _configuration;
        public NewspaperPublisher(INewsSourceRegistry newsSourceRegistery, IAppConfiguration configuration)
        {
            _newsSourceRegistery = newsSourceRegistery;
            _configuration = configuration;
        }
        public async Task<IEnumerable<News>> Publish(int pageNumber)
        {
            INewsSource source = new InternalNewsSource();
            await _newsSourceRegistery.Register(source);

            source = new GoogleNewsSource();
            await _newsSourceRegistery.Register(source);

            source = new PressTrustOfIndiaNewsSource();
            await _newsSourceRegistery.Register(source);

            var list = await _newsSourceRegistery.GetAllRegisteredNews();

            var filteredList =  list.Skip((pageNumber - 1) * _configuration.MaxItemsPerPage).Take(_configuration.MaxItemsPerPage);

            return filteredList;
        }
    }
}
