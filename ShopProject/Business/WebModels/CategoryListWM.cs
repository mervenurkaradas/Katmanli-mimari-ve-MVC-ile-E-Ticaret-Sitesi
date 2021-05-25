using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.WebModels
{
    public class CategoryListWM
    {
        public List<Category> Categories { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

    }
}
