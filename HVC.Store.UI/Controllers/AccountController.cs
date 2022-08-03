using HVC.Store.Data.EF.Repositories;
using HVC.Store.Domain.Contracts.Repositories;
using HVC.Store.UI.Infra.Helpers;
using HVC.Store.UI.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace HVC.Store.UI.Controllers {
    public class AccountController:Controller {
        private readonly IUserRepository _userRepo = new UserRepositoryEF();

        [HttpGet]
        public ActionResult Login(string returnUrl) {
            var model = new LoginVM() { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model) {

            //Verifica se o usuário existe
            //var user = _ctx.users.FirstOrDefault(u => u.EMail == model.EMail);
            var user = _userRepo.Get(model.EMail);
            if (user == null) {
                ModelState.AddModelError("EMail", "E-Mail não encontrado!");
            } else {
                if (user.Password != model.Password.Encrypt()) {
                    ModelState.AddModelError("Password", "Senha Inválida!");
                }
            }

            //Verifica se está autenticado
            if (ModelState.IsValid) {
                FormsAuthentication.SetAuthCookie(model.EMail, model.UserLogged);

                if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl)) {
                    return Redirect(model.ReturnUrl);
                }
                return RedirectToAction("Index", "Home");
                //return RedirectToAction("Index", "Products");
            }
            
            return View(model);
        }

        [HttpGet]
        public ActionResult Logout() {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        protected override void Dispose(bool disposing) {
            _userRepo.Dispose();
        }
    }
}
