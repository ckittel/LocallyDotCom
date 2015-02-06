using System.Collections.Generic;
using RestSharp.Deserializers;

namespace LocallyDotCom.Models
{
    public class BrandsResponse
    {
        public int Status { get; set; }
        public int Count { get; set; }

        [DeserializeAs(Name = "data")]
        public List<Brand> Brands { get; set; }
    }
}
