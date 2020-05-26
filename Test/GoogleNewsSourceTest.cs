using NewsPaper;
using System;
using Xunit;

namespace Test
{
    public class GoogleNewsSourceTest
    {
        [Fact]
        public void TC1_GetNews_Datewise()
        {
            GoogleNewsSource GoogleNews = new GoogleNewsSource();
            var result = GoogleNews.GetNews(x=>x.CreatedAt >= DateTime.UtcNow.AddDays(-1));
            Assert.NotNull(result);
        }
        
        [Fact]
        public void TC2_Get_SportNews()
        {
            GoogleNewsSource GoogleNews = new GoogleNewsSource();
            var result = GoogleNews.GetNews(x => x.Category.Name == "Sports");
            Assert.NotNull(result);
        }

        [Fact]
        public void TC3_Get_PoliticalNews()
        {
            GoogleNewsSource GoogleNews = new GoogleNewsSource();
            var result = GoogleNews.GetNews(x => x.Category.Name == "Political");
            Assert.NotNull(result);
        }
    }
}
