using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.WebModels
{
    public class ProductWM
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70,MinimumLength =10,ErrorMessage ="Ürün ismi minimum 10, maximum 70 karakter olmalıdır!")]
        public string Name { get; set; }
        [Required]
        [Range(1,20000)]
        public decimal? Price { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 20, ErrorMessage = "Ürün açıklaması minimum 20, maximum 100 karakter olmalıdır!")]
        public string Description { get; set; }
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

        //public List<Category> SelectedCategories { get; set; }
    }
}
