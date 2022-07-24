using HVC.Store.UI.Data;
using HVC.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HVC.Store.UI.Controllers {
    public class ProductsController:Controller {
        public ViewResult Index() {

            IList<Product> products = null;
            using (var ctx = new HVCStoreDataContext()) {
                products = ctx.products.ToList();
            }
            return View(products);
        }

        [HttpGet]
        public ViewResult Add() {
            return View();
        }

        [HttpPost]
        public ViewResult Add(Product product) {
            //todo add in the table
            return View();
        }
    }
}
