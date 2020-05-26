using Moq;
using NewsPaper;
using Xunit;

namespace Test
{
    public class NewsSourceRegistryTest
    {
        private NewsSourceRegistry newsSourceRegistery;
        public NewsSourceRegistryTest()
        {
            newsSourceRegistery = new NewsSourceRegistry();
        }

        [Fact]
        public void TC1_RegisterInternalNewsSource()
        {
            //Arrange
            var INewsSourceMock = new Mock<InternalNewsSource>();

            //Act
            var result = newsSourceRegistery.Register(INewsSourceMock.Object);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void TC2_RegisterGoogleNewsSource()
        {
            //Arrange
            var INewsSourceMock = new Mock<GoogleNewsSource>();

            //Act
            var result = newsSourceRegistery.Register(INewsSourceMock.Object);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void TC3_RegisterPTISource()
        {
            //Arrange
            var INewsSourceMock = new Mock<PressTrustOfIndiaNewsSource>();

            //Act
            var result = newsSourceRegistery.Register(INewsSourceMock.Object);

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async void TC4_GetAllRegisteredNews()
        {
            //Arrange
            INewsSource source = new InternalNewsSource();
            await newsSourceRegistery.Register(source);

            source = new GoogleNewsSource();
            await newsSourceRegistery.Register(source);

            source = new PressTrustOfIndiaNewsSource();
            await newsSourceRegistery.Register(source);

            //Act
            var result = newsSourceRegistery.GetAllRegisteredNews();

            //Assert
            Assert.NotNull(result);
        }
    }
}
