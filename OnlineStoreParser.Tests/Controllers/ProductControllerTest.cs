using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineStoreParser.Controllers;
using System.Web.Mvc;
using Moq;
using System.Data.Entity;
using System.Linq;
using OnlineStoreParser.Models;
using System.Web;
using System.IO;

namespace OnlineStoreParser.Tests.Controllers{


    [TestClass]
    public class ProductControllerTest
    {  
        [TestMethod]
        public void IndexViewResultNotNull()
        {
            ProductController controller = new ProductController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SingleProductViewResultNotNull()
        {
            ProductController controller = new ProductController();
            ViewResult result = controller.SingleProduct("45") as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductNotFoundTest()
        {
            var mockHelper = new Mock<Helper>();
            mockHelper.Setup(h => h.getProductById(It.IsAny<string>())).Returns<Product>(null);

            ProductController controller = new ProductController(mockHelper.Object);

            ViewResult result = controller.SingleProduct("i'm not exist") as ViewResult;
            Assert.AreEqual("~/Views/Product/ProductNotFound.cshtml", result.ViewName);
        }

    }

}
