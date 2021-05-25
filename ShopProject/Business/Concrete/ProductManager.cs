using Business.Abstract;
using Business.WebModels;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal= productDal;
        }
        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public ProductListWM GetAll()
        {
            var productData = _productDal.GetAll().ToList();
            var resultData = ProductMapper.ProductToWm(productData);
            return resultData;
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        //public Product GetByIdWithCategories(int id)
        //{
        //    return _productDal.GetByIdWithCategories(id);
        //}

        public List<Product> GetPopularMethod()
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(int id)
        {
            return _productDal.GetProductDetails(id);
        }

        public ProductListWM GetProductsByCategory(string category)
        {
            var productsByCategoryData = _productDal.GetProductsByCategory(category).ToList();
            var resultData = ProductMapper.ProductToWm(productsByCategoryData);
            return resultData;
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
