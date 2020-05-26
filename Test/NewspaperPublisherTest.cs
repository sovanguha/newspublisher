using Moq;
using NewsPaper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    public class NewspaperPublisherTest
    {
        private readonly Mock<INewsSourceRegistry> _mockNewsSourceRegistery;
        private readonly Mock<IAppConfiguration> _mockAppConfig;


        public NewspaperPublisherTest()
        {
            _mockNewsSourceRegistery = new Mock<INewsSourceRegistry>();
            _mockAppConfig = new Mock<IAppConfiguration>();
        }

        [Fact]
        public void TC1_GetPublishData()
        {
            var googleSource = new GoogleNewsSource();
            var internalSource = new InternalNewsSource();
            var ptiSource = new PressTrustOfIndiaNewsSource();

            var newsList = new List<News>()
            {
                 new News{
                    Title = "New 1",
                    Content = "Content 1",
                    CreatedAt = DateTime.UtcNow,
                    IsBreaking = false,
                    Priority = 0,
                    PublishedAt = DateTime.UtcNow,
                    Category = new NewsCategory{Id = 1, Name = "Sports", IsAdvertisement = true}
                },
                new News{
                    Title = "New 2",
                    Content = "Content 2",
                    CreatedAt = DateTime.UtcNow,
                    IsBreaking = false,
                    Priority = 0,
                    PublishedAt = DateTime.UtcNow,
                    Category = new NewsCategory{Id = 1, Name = "Sports", IsAdvertisement = true}
                }
            };

            var pageNumber = 1;

            var publisher = new NewspaperPublisher(_mockNewsSourceRegistery.Object, _mockAppConfig.Object);

            _mockNewsSourceRegistery.Setup(x => x.Register(googleSource)).Returns(Task.CompletedTask);
            _mockNewsSourceRegistery.Setup(x => x.Register(internalSource)).Returns(Task.CompletedTask);
            _mockNewsSourceRegistery.Setup(x => x.Register(ptiSource)).Returns(Task.CompletedTask);

            _mockNewsSourceRegistery.Setup(x => x.GetAllRegisteredNews()).Returns(Task.FromResult<IEnumerable<News>>(newsList));


            var result = publisher.Publish(pageNumber);

            Assert.NotNull(result);
        }
    }
}
