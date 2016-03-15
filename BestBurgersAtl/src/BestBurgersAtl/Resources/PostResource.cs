using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestBurgersAtl.Resources
{
    public class PostResource : IPostResource
    {
        public string ContentText { get; set; }
        public DateTime CreateDt { get; set; }
        public string Description { get; set; }
        public string DisplayImageUrl { get; set; }
        public int Id { get; set; }
        public string SEO { get; set; }
        public DateTime? UpdateDt { get; set; }
        public int Views { get; set; }
    }

    public interface IPostResource
    {
    }
}
