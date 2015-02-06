using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocallyDotCom.Clients
{
    public class CatalogClient : ClientBase
    {
        public CatalogClient(IApiConnection connection) :
            base(connection) { }

        public Task<CatalogResponse> Get(int brandId)
        {
            return ApiConnection.Get<CatalogResponse>(ApiUrls.Catalog,
                new[] {new KeyValuePair<string, string>("brand_id", brandId.ToString())});
        }
    }
}