using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NewsPaper
{
    public class InternalNewsSource : NewsSource
    {
        public override Task<IEnumerable<News>> GetNews(Func<News, bool> condition)
        {
            var result =  new List<News>()
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
                },
                new News{
                    Title = "New 3",
                    Content = "Content 3",
                    CreatedAt = DateTime.UtcNow,
                    IsBreaking = false,
                    Priority = 1,
                    PublishedAt = DateTime.UtcNow,
                    Category = new NewsCategory{Id = 1, Name = "Sports", IsAdvertisement = false}
                },
                new News{
                    Title = "New 4",
                    Content = "Content 4",
                    CreatedAt = DateTime.UtcNow,
                    IsBreaking = false,
                    Priority = 1,
                    PublishedAt = DateTime.UtcNow,
                    Category = new NewsCategory{Id = 1, Name = "Sports", IsAdvertisement = true}
                },
                new News{
                    Title = "New 5",
                    Content = "Content 5",
                    CreatedAt = DateTime.UtcNow,
                    IsBreaking = false,
                    Priority = 1,
                    PublishedAt = DateTime.UtcNow,
                    Category = new NewsCategory{Id = 1, Name = "Sports", IsAdvertisement = true}
                },
                new News{
                    Title = "New 6",
                    Content = "Content 6",
                    CreatedAt = DateTime.UtcNow,
                    IsBreaking = false,
                    Priority = 1,
                    PublishedAt = DateTime.UtcNow,
                    Category = new NewsCategory{Id = 1, Name = "Sports", IsAdvertisement = true}
                }
            }.AsQueryable();

            return Task.FromResult(result.Where(condition).OrderByDescending(x=>x.Priority).AsEnumerable());
        }
    }
}
