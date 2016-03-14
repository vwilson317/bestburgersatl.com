using System.Collections.Generic;
using System.Linq;
using Resources;
namespace DataAccess
{
    public class PostRepository : IPostRepository// LookupRepositoryBase<PostResource>, IPostRepository
    {
        public  IEnumerable<PostResource> GetAll()
        {
            return Enumerable.Repeat(new PostResource { Description = "Test Post", ContentText = "Mock post no html" }, 1);
        }
    }
}
