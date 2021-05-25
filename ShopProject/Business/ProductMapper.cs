using Business.WebModels;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class ProductMapper
    {
        public static ProductListWM ProductToWm(List<Product> model)
        {
            return new ProductListWM()
            {
                Products = model,
            };

        }

    }
}
