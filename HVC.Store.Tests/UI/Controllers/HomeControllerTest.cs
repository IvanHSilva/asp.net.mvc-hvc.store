using HVC.Store.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace HVC.Store.Tests.UI.Controllers {
    [TestClass, TestCategory("Constrollers/HomeController")]
    public class HomeControllerTest {

        //HomeController
        [TestMethod]
        public void IndexMethodMustBeReturnAView() {
            //arrange
            var homeController = new HomeController();

            //act
            var result = homeController.Index();

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }
    }
}
