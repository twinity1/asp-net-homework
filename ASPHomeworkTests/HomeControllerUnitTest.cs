using System.Collections.Generic;
using ASPHomework.Persistence.Entities;
using ASPHomework.Persistence.Repositories.Interfaces;
using ASPNetCoreHomework.Controllers;
using ASPNetCoreHomework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASPHomeworkTests
{
    [TestClass]
    public class HomeControllerUnitTest
    {
        [TestMethod]
        public void TestIndex()
        {
            var destinations = new List<Destination>()
            {
                new Destination()
                {
                    Id = 1,
                    Capacity = 14,
                    Title = "Itálie",
                    Description = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book."
                }, new Destination()
                {
                    Id = 2,
                    Capacity = 10,
                    Title = "Řecko",
                    Description = "In publishing and graphic design, Lorem ipsum is a .placeholder text commonly used to demonstrate the visual form of a document or a typeface without relying ..."
                }
            };
            
            var mock = new Mock<IDestinationRepository>();

            mock.Setup(dr => dr.FindAll()).Returns(destinations);
            
            var controller = new HomeController(mock.Object);
            
            var actionResult = controller.Index();
            Assert.IsInstanceOfType(actionResult, typeof(ViewResult));

            var viewResult = (ViewResult) actionResult;
            Assert.IsInstanceOfType(viewResult.Model, typeof(HomeIndexViewModel));

            var viewModel = (HomeIndexViewModel) viewResult.Model;
            
            Assert.AreEqual(2, viewModel.Destinations.Count);
        }
    }
}