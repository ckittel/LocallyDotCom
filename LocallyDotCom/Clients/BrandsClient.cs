using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocallyDotCom.Clients
{
    public class BrandsClient : ClientBase
    {
        public BrandsClient(IApiConnection connection) :
            base(connection) { }

        public Task<BrandsResponse> GetAll()
        {
            return ApiConnection.Get<BrandsResponse>(ApiUrls.Brands);
        }

        public Task<BrandsResponse> GetAllParticipating()
        {
            return ApiConnection.Get<BrandsResponse>(ApiUrls.Brands,
                new[] {new KeyValuePair<string, string>("is_participating", "true")});
        }
    }
}
