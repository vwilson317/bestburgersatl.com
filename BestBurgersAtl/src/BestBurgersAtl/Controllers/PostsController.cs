using System.Collections.Generic;
using BestBurgersAtl.Resources;
using BestBurgersAtl.Resources.DA;
using Microsoft.AspNet.Mvc;

namespace BestBurgersAtl.Controllers
{
    [Route("api/[controller]")]
    public class PostsController //: BaseApiController<PostResource>
    {
        [FromServices]
        IPostRepository PostRepository { get; set; }

        public PostsController(IPostRepository repoService)
        {
            //TODO: Fix Di
            PostRepository = repoService;
        }

        [HttpGet]
        public IEnumerable<PostResource> Get()
        {
            return PostRepository.GetAll();
        }
    }
}
