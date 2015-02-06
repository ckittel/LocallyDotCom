using System;

namespace LocallyDotCom
{
    public class CatalogProduct
    {
        public int ProductId { get; set; }
        public string Upc { get; set; }
        public string Name { get; set; }
        public Uri Image { get; set; }
        public string StyleNumber { get; set; }
        public int? CategoryId { get; set; }
        public Uri DirectUrl { get; set; }
        public decimal UnitMsrp { get; set; }
        public Uri LocallyUrl { get; set; }
        public string Gender { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public string Size1 { get; set; }
        public string Size2 { get; set; }
    }
}