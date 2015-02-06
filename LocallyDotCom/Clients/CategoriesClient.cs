using System.Threading.Tasks;

namespace LocallyDotCom.Clients
{
    public class CategoriesClient : ClientBase
    {
        public CategoriesClient(IApiConnection connection)
            : base(connection) { }

        public Task<CategoriesResponse> Get()
        {
            return ApiConnection.Get<CategoriesResponse>(ApiUrls.Categories);
        }
    }
}