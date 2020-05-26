using NewsPaper;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    public class PressTrustOfIndiaNewsSourceTest
    {
        [Fact]
        public void ItThrowsNotImplementException()
        {
            //Arrange
            var pressTrustOfIndiaNews = new PressTrustOfIndiaNewsSource();

            //Act
            var result = Record.ExceptionAsync(() => pressTrustOfIndiaNews.GetNews(x => x.CreatedAt >= DateTime.UtcNow.AddDays(-1)));

            //Arrange
            Assert.IsAssignableFrom<NotImplementedException>
            (result.Result.GetBaseException());
            Assert.Equal("Delete is not avaliable for TestEntity",
            result.Result.Message);
        }
    }
}
