﻿using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product, ShopContext>, IProductDal
    {
        public Product GetByIdWithCategories(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Products
                       .Where(i => i.Id == id)
                       .Include(i => i.ProductCategories)
                       .ThenInclude(i => i.Category)
                       .FirstOrDefault();
            }
        }

        public Product GetProductDetails(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Products
                    .Where(i => i.Id == id)
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

        public List<Product> GetProductsByCategory(string category)
        {
            using (var context = new ShopContext())
            {
                var products = context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    products = products
                              .Include(i => i.ProductCategories)
                              .ThenInclude(i => i.Category)
                              .Where(i => i.ProductCategories.Any(a => a.Category.Name.ToLower() == category.ToLower()));
                }
                return products.ToList();
            }
        }


    }
}

