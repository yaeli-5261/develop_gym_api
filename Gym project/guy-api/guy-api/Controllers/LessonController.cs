
using Gym.Core.Entities;
using Gym.Core.Interface;
using Gym.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace guy_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            _lessonService=lessonService;
        }

        // GET: api/<LessonController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_lessonService.GetAll());
        }

        // GET api/<LessonController>/5
        [HttpGet("{day}")]
        public ActionResult Get(Weekday day)
        {
            return Ok(_lessonService.GetByDay(day));
        }
        [HttpGet("{day}/{typesOfFitness}")]
        public ActionResult Get(Weekday day, EnumTypeOfFitness typesOfFitness)
        {
            return Ok(_lessonService.Get(day, typesOfFitness));
           
        }
        // POST api/<LessonController>
        [HttpPost]
        public void Post(int id,EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel)
        {
            _lessonService.Post(id,type, trainerId, target_audience, day, start, during, enumLevel);
        }

        //// PUT api/<LessonController>/5
        [HttpPut("{code}")]
        public void Put(int id, EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel)
        {
             _lessonService.Put( id,  type,  trainerId,  target_audience,  day,  start,  during,  enumLevel);
           
        }

        //// DELETE api/<LessonController>/5
        [HttpDelete("{code}")]
        public void Delete(int id)
        {
            _lessonService.Delete(id);
        }
    }
}
