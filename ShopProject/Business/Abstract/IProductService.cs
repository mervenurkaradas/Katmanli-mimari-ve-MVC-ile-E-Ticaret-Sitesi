using Business.WebModels;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        Product GetProductDetails(int id);
        ProductListWM GetAll();
        List<Product> GetPopularMethod();
        ProductListWM GetProductsByCategory(string category);
        Product GetById(int id);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        //Product GetByIdWithCategories(int id);
    }
}
