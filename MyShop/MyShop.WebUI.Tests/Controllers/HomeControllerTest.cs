using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShop.Core.Contracts;
using MyShop.Core.Models;
using MyShop.Core.ViewModels;
using MyShop.WebUI;
using MyShop.WebUI.Controllers;

namespace MyShop.WebUI.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IndexPageDoesReturnProducts()
        {
            IRepository<Product> productContext = new Mocks.MockContext<Product>();
            IRepository<ProductCategory> productCategoryContext = new Mocks.MockContext<ProductCategory>();

            productContext.Insert(new Product());

            HomeController controller = new HomeController(productContext, productCategoryContext);

            var result = controller.Index() as ViewResult;
            var viewModel = (ProductListViewModel)result.ViewData.Model; //explicit cast

            Assert.AreEqual(1, viewModel.Products.Count());
        }
    }
    //[TestClass]
    //public class HomeControllerTest
    //{
    //    [TestMethod]
    //    public void Index()
    //    {
    //        // Arrange //instantiate the controller for testing
    //        HomeController controller = new HomeController();

    //        // Act //get a result from the controller
    //        ViewResult result = controller.Index() as ViewResult;

    //        // Assert //see if the test was correct or not
    //        Assert.IsNotNull(result);
    //    }

    //    [TestMethod]
    //    public void About()
    //    {
    //        // Arrange
    //        HomeController controller = new HomeController();

    //        // Act
    //        ViewResult result = controller.About() as ViewResult;

    //        // Assert
    //        Assert.AreEqual("Your application description page.", result.ViewBag.Message);
    //    }

    //    [TestMethod]
    //    public void Contact()
    //    {
    //        // Arrange
    //        HomeController controller = new HomeController();

    //        // Act
    //        ViewResult result = controller.Contact() as ViewResult;

    //        // Assert
    //        Assert.IsNotNull(result);
    //    }
    //}
}
