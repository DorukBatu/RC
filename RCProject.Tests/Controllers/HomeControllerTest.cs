﻿using System.Web.Mvc;
//using NUnit.Framework;
using RCProject.Controllers;
using Xunit;

namespace RCProject.Tests.Controllers
{
   
    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {
            // Arrange
            
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            //commentaddded
            Assert.NotNull(result);
        }

        [Fact]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}
