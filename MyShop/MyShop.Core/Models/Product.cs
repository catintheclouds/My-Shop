using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        public string Id { get; set; }
        [StringLength(20)]
        [System.ComponentModel.DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, 1000)]
        public decimal Price { get; set; }
        public string Category { get; set; } //to use as a GROUP for products
        public string Image { get; set; } //contains URL for image
        public Product() //constructor; to always generate a ID number per instance of product
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
