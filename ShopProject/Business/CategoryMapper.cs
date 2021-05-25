using Business.Abstract;
using Business.WebModels;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public static class CategoryMapper 
    {
        public static CategoryListWM CategoryToWm(List<Category> model)
        {
            return new CategoryListWM()
            {
                Categories = model,
            };

        }
    }
}
