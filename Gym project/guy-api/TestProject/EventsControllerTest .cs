using guy_api.Controllers;
using guy_api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace TestProject
{
    public class EventsControllerTest
    {
        [Fact]
        public void GetById_ReturnsOk()
        {
            var id = "1";

            var controller = new TrainerController();
            var result = controller.Get(id);

            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public void GetById_Returns_NotFound()
        {
            var id = "-1";

            var controller = new TrainerController();
            var result = controller.Get(id);

            Assert.IsType<NotFoundObjectResult>(result);

        }
        [Fact]
        public void GetAll_Returns_ListsTrainner()
        {
            var controller = new TrainerController();
            var result = controller.Get();

            Assert.IsType<OkObjectResult>(result);

        }
    }

}