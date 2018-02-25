using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using WordCounter.Controllers;


      [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]

        public void Index_HasCorrectModelType_CountList()
        {
            //Arrange
            HomeController controller = new HomeController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<RepeatCounter>));
        }
}
