using LocallyDotCom.Clients;
using LocallyDotCom.Http;

namespace LocallyDotCom
{
    public class LocallyDotComClient
    {
        public LocallyDotComClient(string apiKey)
        {
            var connection = new ApiConnection(apiKey);
            Brands = new BrandsClient(connection);
            Catalog = new CatalogClient(connection);
            Categories = new CategoriesClient(connection);
        }

        public BrandsClient Brands { get; private set; }

        public CatalogClient Catalog { get; private set; }

        public CategoriesClient Categories { get; private set; }
    }
}
