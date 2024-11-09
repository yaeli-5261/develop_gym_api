namespace UnitTest_project
{
    public class EventsControllerTest
    {
        [Fact]
        public void GetAll_ReturnsOk()
        {
            //Arrange
            
        }
        public void Get_NutFoundId()
        {
            string id = "1";
            var controller = new TrainerController();
            var result = controller.Get(id);
            Assert.IsType<OkObjectResult>(result);

        }
    }
}