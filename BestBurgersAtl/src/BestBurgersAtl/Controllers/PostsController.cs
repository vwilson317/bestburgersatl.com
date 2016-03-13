﻿using System.Collections.Generic;
using BestBurgersAtl.Resources;
using BestBurgersAtl.Resources.DA;
using Microsoft.AspNet.Mvc;

namespace BestBurgersAtl.Controllers
{
    [Route("api/[controller]")]
    public class PostsController //: BaseApiController<PostResource>
    {
        [FromServices]
        IPostRepository Service2 { get; set; }

        public PostsController(IPostRepository repoService)
        {
            //TODO: Fix Di
            Service2 = repoService;// new PostRepository();
        }

        [HttpGet]
        public IEnumerable<PostResource> Get()
        {
            return Service2.GetAll();
        }
    }
}
