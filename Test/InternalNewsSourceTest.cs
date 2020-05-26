using Xunit;
using NewsPaper;
using System;

namespace Test
{
    public class InternalNewsSourceTest
    {

        [Fact]
        public void TC1_GetNews_Datewise()
        {
            InternalNewsSource GoogleNews = new InternalNewsSource();
            var result = GoogleNews.GetNews(x => x.CreatedAt >= DateTime.UtcNow.AddDays(-1));
            Assert.NotNull(result);
        }

        [Fact]
        public void TC2_Get_SportNews()
        {
            InternalNewsSource GoogleNews = new InternalNewsSource();
            var result = GoogleNews.GetNews(x => x.Category.Name == "Sports");
            Assert.NotNull(result);
        }

        [Fact]
        public void TC3_Get_PoliticalNews()
        {
            InternalNewsSource GoogleNews = new InternalNewsSource();
            var result = GoogleNews.GetNews(x => x.Category.Name == "Political");
            Assert.NotNull(result);
        }
    }
}