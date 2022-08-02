using HVC.Store.Data.EF;
using HVC.Store.Domain.Entities;
using System.Linq;
using System.Web.Mvc;

namespace HVC.Store.UI.Controllers {
    [Authorize]
    public class ProductsController:Controller {

        private readonly HVCStoreDataContext _ctx = new HVCStoreDataContext();
        
        public ViewResult Index() {
            var products = _ctx.products.ToList();
            return View(products);
        }

        [HttpGet]
        public ViewResult AddEdit(int? id) {
            Product product = new Product();
            
            if (id != null) {
                product = _ctx.products.Find(id);
            }
            
            var types = _ctx.prodtypes.ToList();
            ViewBag.Types = types; //atalho para o ViewData
            //ViewData["Types"] = types;

            return View(product);
        }

        //[HttpGet]
        //public ActionResult Edit(int id) {
        //    var product = _ctx.products.Find(id);
        //    return View(product);
        //}

        [HttpPost]
        public ActionResult AddEdit(Product product) {

            if (ModelState.IsValid) {
                if (product.Id == 0) {
                    _ctx.products.Add(product);
                }
                else {
                    _ctx.Entry(product).State = System.Data.Entity.EntityState.Modified;
                }

                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }

            var types = _ctx.prodtypes.ToList();
            ViewBag.Types = types; //atalho para o ViewData

            return View(product);
        }

        public ActionResult DelProd(int id) {
            var product = _ctx.products.Find(id);

            if (product == null) {
                return HttpNotFound();
            }

            _ctx.products.Remove(product);
            _ctx.SaveChanges();

            return null;
        }

        protected override void Dispose(bool disposing) {
            _ctx.Dispose();
        }
    }
}
