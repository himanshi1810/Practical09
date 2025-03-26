using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;
using Task3.Controllers;
using Task3.Models;

namespace Task3.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);//For checking that my view is not null
            Assert.IsNotNull(result.Model);//Checks that the passing model is not null
            var model = result.Model as Message;
            Assert.IsNotNull(model);
            Assert.AreEqual("Hello, World!", model.PlainText); //Checking the passing string is hello world
        }
    }
}
