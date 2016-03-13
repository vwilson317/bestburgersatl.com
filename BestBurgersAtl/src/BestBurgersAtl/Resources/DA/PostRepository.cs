using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestBurgersAtl.Resources.DA
{
    public class PostRepository : IPostRepository// LookupRepositoryBase<PostResource>, IPostRepository
    {
        public  IEnumerable<PostResource> GetAll()
        {
            return Enumerable.Repeat(new PostResource { Description = "Test Post", ContentText = "Mock post no html" }, 1);
        }
    }
}
