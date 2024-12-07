using Gym.Core.Entities;
using Gym.Core.Interface;
using Gym.Core.Services;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace guy_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {

        private readonly ITrainerService _trinerService;

        public TrainerController(ITrainerService trainerService)
        {
            _trinerService= trainerService;
        }

        //// GET: api/<TrainerController>
        [HttpGet]

        public ActionResult Get()
        {
            return Ok(_trinerService.GetAll());
        }
        //// GET api/<TrainerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_trinerService.GetById(id));
        }

        //// POST api/<TrainerController>
        [HttpPost]

        public void Post(int id, string FirstName, string LastName, EnumGender Gender, String Phon, String Mail, EnumTypeOfFitness TypeOfFitness)
        {
            _trinerService.Post(id, FirstName, LastName, Gender, Phon, Mail, TypeOfFitness);
        }

        //// PUT api/<TrainerController>/5

        [HttpPut("{id}")]
        public void Put(int id, string FirstName, string LastName, EnumGender Gender, String Pel, String Mail, EnumTypeOfFitness TypeOfFitness)
        {
            _trinerService.Put(id, FirstName, LastName, Gender, Pel, Mail, TypeOfFitness);
         
        }

        [HttpPut("{id}/{isActiveTrainer}")]

        public void Put(int id, bool isActiveTrainer)
        {
            _trinerService.PutActive(id,isActiveTrainer);
        }

        //// DELETE api/<TrainerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _trinerService.Delete(id);

        }
    }
}
