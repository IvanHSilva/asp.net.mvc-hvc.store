using HVC.Store.Data.EF.Repositories;
using HVC.Store.Domain.Contracts.Repositories;
using HVC.Store.Domain.Entities;
using HVC.Store.UI.ViewModels.Products.AddEdit;
using HVC.Store.UI.ViewModels.Products.AddEdit.Maps;
using HVC.Store.UI.ViewModels.Products.Index;
using HVC.Store.UI.ViewModels.Products.Index.Maps;
using System.Web.Mvc;

namespace HVC.Store.UI.Controllers {
    [Authorize]
    public class ProductsController : Controller {

        private readonly IProductRepository _prodRepo = new ProductRepositoryEF();
        private readonly IProductTypeRepository _prodTypeRepo = new ProductTypeRepositoryEF();
        
        public ViewResult Index() {
            //var products = _prodRepo.Get();

            var products = _prodRepo.Get().ToProductIndexVM();

            return View(products);
        }

        [HttpGet]
        public ViewResult AddEdit(int? id) {
            var product = new ProductAddEditVM();
            
            if (id != null) {
                product = _prodRepo.Get((int)id).ToProductAddEditVM();
            }
            
            var types = _prodTypeRepo.Get();
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
        public ActionResult AddEdit(ProductAddEditVM productVM) {

            Product product = productVM.ToProduct();

            if (ModelState.IsValid) {

                if (product.Id == 0) {
                    _prodRepo.Add(product);
                }
                else {
                    //_ctx.Entry(product).State = System.Data.Entity.EntityState.Modified;
                    _prodRepo.Edit(product);
                }

                return RedirectToAction("Index");
            }

            var types = _prodTypeRepo.Get();
            ViewBag.Types = types; //atalho para o ViewData

            return View(product);
        }

        public ActionResult DelProd(int id) {
            var product = _prodRepo.Get(id);

            if (product == null) {
                return HttpNotFound();
            }

            _prodRepo.Delete(product);

            return null;
        }

        protected override void Dispose(bool disposing) {
            _prodRepo.Dispose();
            _prodTypeRepo.Dispose();
        }
    }
}
