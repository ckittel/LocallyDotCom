using System.Collections.Generic;
using RestSharp.Deserializers;

namespace LocallyDotCom.Models
{
    public class CatalogResponse
    {
        public int Status { get; set; }
        public int Count { get; set; }
        public string Message { get; set; }

        [DeserializeAs(Name = "data")]
        public List<CatalogProduct> Products { get; set; }
    }
}