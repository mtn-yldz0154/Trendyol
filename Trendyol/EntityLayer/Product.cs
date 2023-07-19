using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductClassName { get; set; }
        public string ProductPrice { get; set; }
        public double Price { get; set; }
        public string ProductImageUrl1 { get; set; }
        public string ProductImageUrl2 { get; set; }
        public string ProductImageUrl3 { get; set; }
        
        public string ProductSalePrice { get; set; }
        public string ProductDespcription { get; set; }
        public string ProductTitle { get; set; }
        public string ProductSize { get; set; }
        public string ProductStarNumber { get; set; }
        public int StarNumber { get; set; }
        public int ProductStock { get; set; }
        public int CategoryId { get; set; }
        public string Color { get; set; }
        public Category Category { get; set; }

    }
}
