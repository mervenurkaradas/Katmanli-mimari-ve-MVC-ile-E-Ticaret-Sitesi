using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.WebModels
{
    public class CartWM
    {
        public int CartId { get; set; }
        public List<CartItemWM> CartItems { get; set; }
        public decimal TotalPrice()
        {
            return CartItems.Sum(i => i.Price * i.Quantity);
        }
    }

    public class CartItemWM
    {
        public int CartItemId { get; set; }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
    }
}
