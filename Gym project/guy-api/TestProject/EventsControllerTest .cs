using guy_api.Controllers;
using Gym.Data.Repositories;
//using guy_api.Entities;
//using guy_api.Interface;
//using guy_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace TestProject
{
    public class EventsControllerTest
    {
        //אין ענין בטסטים ליצור בכל פעם מופע ולכן יוצרת פעם אחת ומאתחלת בבונה
        private readonly TrainerController _trainerController ;

        public EventsControllerTest()
        {
            _trainerController =  new TrainerController(new DataContext());
        }

        [Fact]
        public void GetById_ReturnsOk()
        {
            var id = "2";

            var result = _trainerController.Get(id);

            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public void GetById_Returns_NotFound()
        {
            var id = "81";

            var result = _trainerController.Get(id);

            Assert.IsType<NotFoundObjectResult>(result);

        }
        [Fact]
        public void GetAll_Returns_ListsTrainner()
        {
            var result = _trainerController.Get();

            Assert.IsType<OkObjectResult>(result);
        }
    }

}