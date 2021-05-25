using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Concrete.EfCore
{
    public static class TestDatabase
    {
        public static void Test()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);
                }

            }
            context.SaveChanges();
        }

        private static Category[] Categories =
        {
             new Category () {Name="Giyim"},
             new Category () {Name="Ceket"},
             new Category () {Name="Gömlek"},
             new Category () {Name="Elbise"},
             new Category () {Name="Pantolon"},
             new Category () {Name="Sweat"}
         };

        private static Product[] Products =
       {
             new Product () {Name="Zara Kırmızı Elbise" , Price=1500 , Image="1.jpg",Description="Güzel Elbise"},
             new Product () {Name="Bershka Sarı Elbise" , Price=2000 , Image="2.jpg",Description="Güzel Elbise"},
             new Product () {Name="Stradivarius Elbise" , Price=1250 , Image="3.jpg",Description="Güzel Elbise"},
             new Product () {Name="H&M Beyaz Elbise" , Price=1250 , Image="4.jpg",Description="Güzel Elbise"},
             new Product () {Name="Zara Tshirt" , Price=1250 , Image="5.jpg",Description="Güzel Elbise"},
             new Product () {Name="Armağan Elbise" , Price=1250 , Image="6.jpg",Description="Güzel Elbise"},
             new Product () {Name="Zarafet Pantolon" , Price=1250 , Image="7.jpg",Description="Güzel Elbise"}

         };
        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory ()  {Product= Products[0],Category=Categories[0]},
            new ProductCategory ()  {Product= Products[0],Category=Categories[3]},
            new ProductCategory ()  {Product= Products[1],Category=Categories[3]},
            new ProductCategory ()  {Product= Products[1],Category=Categories[0]},
            new ProductCategory ()  {Product= Products[2],Category=Categories[0]},
            new ProductCategory ()  {Product= Products[2],Category=Categories[3]},
            new ProductCategory ()  {Product= Products[3],Category=Categories[2]},
            new ProductCategory ()  {Product= Products[3],Category=Categories[3]},
            new ProductCategory ()  {Product= Products[4],Category=Categories[0]},
            new ProductCategory ()  {Product= Products[4],Category=Categories[2]},
            new ProductCategory ()  {Product= Products[5],Category=Categories[0]},
            new ProductCategory ()  {Product= Products[5],Category=Categories[1]},
            new ProductCategory ()  {Product= Products[6],Category=Categories[0]},
            new ProductCategory ()  {Product= Products[6],Category=Categories[4]}

        };

    }
}
