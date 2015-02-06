using System.Collections.Generic;
using RestSharp.Deserializers;

namespace LocallyDotCom.Models
{
    public class CategoriesResponse
    {
        public int Status { get; set; }
        public int Count { get; set; }

        [DeserializeAs(Name = "data")]
        public List<Category> Categories { get; set; }
    }
}
