using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNet.Mvc;
using DataAccess;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BestBurgersAtl.Controllers
{
    public class BaseApiController<TReturnType> : Controller
    {
        [FromServices]
        public ILookupReposiotry<TReturnType> Service { get; set; }
        // GET: api/values
        [HttpGet]
        public virtual IEnumerable<TReturnType> Get()
        {
            return Service.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public virtual TReturnType Get(int id)
        {
            return Service.FindById(id);
        }

        // POST api/values
        [HttpPost]
        public virtual void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public virtual void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public virtual void Delete(int id)
        {
        }
    }
}
