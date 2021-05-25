using Business.Abstract;
using Business.WebModels;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private ICartService _cartService;
        private UserManager<ApplicationUser> _userManager;
        //private IOrderService _orderService;
        public CartController(ICartService cartService, UserManager<ApplicationUser> userManager)
        {
            //_orderService = orderService;
            _cartService = cartService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));

            return View(new CartWM()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemWM()
                {
                    
                    ProductId = i.Product.Id,
                    Name = i.Product.Name,
                    Price = (decimal)i.Product.Price,
                    Image = i.Product.Image,
                    Quantity = i.Quantity
                }).ToList()
            });
        }  
        [HttpPost]
        public IActionResult AddToCart(int productId,int quantity)
        {
            _cartService.AddToCart(_userManager.GetUserId(User), productId, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteFromCart(int productId)
        {
            _cartService.DeleteFromCart(_userManager.GetUserId(User), productId);
            return RedirectToAction("Index");
        }



        public IActionResult Checkout()
        {

            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            var orderModel = new OrderWM();
            orderModel.CartWM = new CartWM()
            {

                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemWM()
                {
                    CartItemId=i.Id,
                    ProductId = i.Product.Id,
                    Name = i.Product.Name,
                    Price = (decimal)i.Product.Price,
                    Image = i.Product.Image,
                    Quantity = i.Quantity
                }).ToList()
            };
          
            return View(orderModel);
        }

        //    [HttpPost]
        //    public IActionResult Checkout(OrderWM model)
        //    {

        //        if (ModelState.IsValid)
        //        {
        //            var userId = _userManager.GetUserId(User);
        //            var cart = _cartService.GetCartByUserId(userId);

        //            model.CartWM = new CartWM()
        //            {
        //                CartId = cart.Id,
        //                CartItems=cart.CartItems.Select(i=>new CartItemWM()
        //                {
        //                    CartItemId=i.Id,
        //                    ProductId = i.Product.Id,
        //                    Name = i.Product.Name,
        //                    Price = (decimal)i.Product.Price,
        //                    Image = i.Product.Image,
        //                    Quantity = i.Quantity
        //                }).ToList()

        //            };
        //            SaveOrder(model, userId);
        //        }
        //        return RedirectToAction("Index");
        //    }


        //    private void SaveOrder(OrderWM model,string userId)
        //    {
        //        var order = new Order();


        //        order.OrderNumber = new Random().Next(111111, 999999).ToString();
        //        order.OrderDate = new DateTime();
        //        order.FirstName = model.FirstName;
        //        order.LastName = model.LastName;
        //        order.Email = model.Email;
        //        order.Phone = model.Phone;
        //        order.Address = model.Address;
        //        order.UserId = userId;

        //        foreach (var item in model.CartWM.CartItems)
        //        {
        //            var orderitem = new OrderItems()
        //            {
        //                Price = item.Price,
        //                Quantity = item.Quantity,
        //                ProductId = item.ProductId,
        //            };
        //            order.OrderItems.Add(orderitem);
        //        }
        //        _orderService.Create(order);

        //    }

    }
}
