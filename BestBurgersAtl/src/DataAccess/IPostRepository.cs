using System.Collections.Generic;
using Resources;

namespace DataAccess
{
    public interface IPostRepository// : ILookupReposiotry<PostResource>
    {
        IEnumerable<PostResource> GetAll();
    }
}