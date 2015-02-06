using System;

namespace LocallyDotCom
{
    public static class ApiUrls
    {
        private static readonly Uri BaseUri = new Uri("http://www.locally.com/api/v1/", UriKind.Absolute);
        private static readonly Uri BrandsEndpoint = new Uri("brands", UriKind.Relative);
        private static readonly Uri CatalogEndpoint = new Uri("catalog", UriKind.Relative);
        private static readonly Uri CatagoriesEndpoint = new Uri("taxonomy", UriKind.Relative);

        public static Uri Base
        {
            get { return BaseUri; }
        }
        public static Uri Brands
        {
            get {  return BrandsEndpoint; }
        }

        public static Uri Catalog
        {
            get { return CatalogEndpoint; }
        }

        public static Uri Categories
        {
            get { return CatagoriesEndpoint; }
        }
    }
}
