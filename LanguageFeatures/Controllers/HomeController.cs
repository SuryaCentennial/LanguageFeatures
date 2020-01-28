using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {



        bool FilterByPrice(Product product) {
            return product?.Price >= 50M;
        }
        bool FilterByName(Product product)
        {
            return product?.Name[0] == 'B';
        }
        #region IndexMain
        //public ViewResult Index()
        //{
        //    #region PatternMatching

        //    ///*
        //    //# kjasd
        //    //            Dictionary<string, Product> products = new Dictionary<string, Product>
        //    //            {
        //    //                ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //    //                ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 49.99M }
        //    //            };
        //    //            return View("Index", products.Keys);
        //    //            */
        //    //            object[] data = new object[] { 275M, 29.99M, "apple", "orange", 100, 10 };
        //    //            decimal total = 0;
        //    //            foreach (object item in data) {
        //    //                /*if (item is decimal d) {
        //    //                    total += d;
        //    //                }*/
        //    //                /*
        //    //                switch (item)
        //    //                {
        //    //                    case decimal d:
        //    //                        total += d;
        //    //                        break;
        //    //                    case int i > 50:

        //    //                }
        //    //                */

        //    //            }
        //    //            return View("Index", new string[] {$"Total:{total}" }); 
        //    #endregion

        //    ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
        //    Product[] arrayOfProducts = new Product[]
        //    {
        //        new Product { Name = "Ball" , Price=9.99M},
        //        new Product { Name = "Flag" , Price=5M},
        //        new Product { Name = "Stopwatch" , Price=54.99M},
        //        new Product { Name = "Running Shoes" , Price=89.99M},
        //        new Product { Name = "Board" , Price=154.99M}

        //    };

        //    #region MyRegion
        //    ////decimal cartTotal = cart.TotalPrices();
        //    ////decimal nameFiltedTotal = arrayOfProducts.Filter(FilterByName).TotalPrices();
        //    //decimal nameFiltedTotal = arrayOfProducts.Filter(p=>p?.Name?[0]=='B').TotalPrices(); 
        //    //decimal differentProductTotal = arrayOfProducts.Filter(FilterByPrice).TotalPrices();
        //    ////note: Lambda Expression -
        //    ////bool Foo (Product p){return p?.Price > = 50M;}
        //    ////boll Foo(Product p,int x){return p?.Price>=50M || x==5;}  similar to (P,x) => P?.Price >= 50M || x==5;


        //    //return View("Index", new string[] { //$"Total: {cartTotal:c}" ,
        //    //    $"Total for different products starts with B:{nameFiltedTotal}",
        //    //    $"Total for different products gt 50M:{differentProductTotal}"}); 
        //    #endregion

        //    return View(Product.GetProducts().Select(p => p?.Name));

        //} 
        #endregion

        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));

        public ViewResult Index()
        {
            //var name = new[] { "Bob", "Ann", "John" };
            var pr = new[] {
                new { Name = "Kayak" , Price = 275M},
                new { Name = "StopWatch" , Price = 186M}
            };
            return View(pr.Select(a=>a.GetType().Name));
        }
    }
}