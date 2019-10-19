using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Basket : BaseEntity // basket item, then collection of basket items
    {
        public virtual ICollection<BasketItem> BasketItems { get; set; } //lazy loading
        
        public Basket()
        {
            this.BasketItems = new List<BasketItem>();
        }
    }
}
