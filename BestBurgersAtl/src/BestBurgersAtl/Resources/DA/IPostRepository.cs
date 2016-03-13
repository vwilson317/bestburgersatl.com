using System.Collections.Generic;

namespace BestBurgersAtl.Resources.DA
{
    public interface IPostRepository// : ILookupReposiotry<PostResource>
    {
        IEnumerable<PostResource> GetAll();
    }
}