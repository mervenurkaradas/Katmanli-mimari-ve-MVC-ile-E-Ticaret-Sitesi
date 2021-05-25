using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.WebModels
{
    public class CategoryWM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
