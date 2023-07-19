using EntityLayer;
using Microsoft.AspNetCore.Http;

namespace Trendyol.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductClassName { get; set; }
        public string Color { get; set; }
        public string ProductPrice { get; set; }
        public IFormFile ProductImageUrl1 { get; set; }
        public string Product1 { get; set; }
        public string Product2 { get; set; }
        public string Product3 { get; set; }
        public IFormFile ProductImageUrl2 { get; set; }
        public IFormFile ProductImageUrl3 { get; set; }

        public string ProductSalePrice { get; set; }
        public string ProductDespcription { get; set; }
        public string ProductTitle { get; set; }
        public string ProductSize { get; set; }
        public string ProductStarNumber { get; set; }
        public int ProductStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
