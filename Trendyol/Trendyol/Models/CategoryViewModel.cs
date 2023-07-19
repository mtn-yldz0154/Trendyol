using EntityLayer;
using System.Collections.Generic;

namespace Trendyol.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}
