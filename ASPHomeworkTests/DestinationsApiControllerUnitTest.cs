using ASPHomework.Controllers.API;
using ASPHomework.Persistence.Entities;
using ASPHomework.Persistence.Repositories.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ASPHomeworkTests
{
    [TestClass]
    public class DestinationsApiControllerUnitTest
    {
        [TestMethod]
        public void TestGetItemNotFound()
        {
            var mockRepo = new Mock<IDestinationRepository>();

            var mockMapper = new Mock<IMapper>(); 
            mockRepo.Setup(dr => dr.FindOneById(2)).Returns((Destination) null);
            
            var controller = new DestinationsController(mockRepo.Object, mockMapper.Object);

            var actionResult = controller.Get(2);
            
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }
        
        [TestMethod]
        public void TestGetItemFound()
        {
            var dest = new Destination()
            {
                Id = 2,
                Capacity = 14,
                Title = "Itálie",
                Description = "xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx xxxxx"
            };
            
            var mockRepo = new Mock<IDestinationRepository>();
            mockRepo.Setup(dr => dr.FindOneById(2)).Returns(dest);

            var mockMapper = new Mock<IMapper>();
            mockMapper.Setup(m => m.Map<DestinationsController.DestinationDto>(dest)).Returns(new DestinationsController.DestinationDto()
            {
                Id = dest.Id,
                Capacity = dest.Capacity,
                Title = dest.Title,
                Description = dest.Description
            });

            var controller = new DestinationsController(mockRepo.Object, mockMapper.Object);

            var actionResult = controller.Get(2);
            
            Assert.IsInstanceOfType(actionResult, typeof(OkObjectResult));

            var result = (OkObjectResult) actionResult;
            
            Assert.IsInstanceOfType(result.Value, typeof(DestinationsController.DestinationDto));
        }
    }
}