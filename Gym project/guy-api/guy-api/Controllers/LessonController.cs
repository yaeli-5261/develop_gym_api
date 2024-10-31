
using guy_api.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace guy_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        // GET: api/<LessonController>
        [HttpGet]
        public ActionResult<List<Lesson>> Get()
        {
            return Ok(Data.ListLesson);
        }

        // GET api/<LessonController>/5
        [HttpGet("{day}")]
        public ActionResult<List<Lesson>> Get(Weekday day)
        {
            return Data.ListLesson.Where(l => l.Day == day).ToList();
         
        }
        [HttpGet("{day}/{typesOfFitness}")]
        public ActionResult<List<Lesson>> Get(Weekday day, EnumTypeOfFitness typesOfFitness)
        {
            return Data.ListLesson.Where(l => l.Day == day && l.Type == typesOfFitness).ToList();
        }
        // POST api/<LessonController>
        [HttpPost]
        public void Post(EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel)
        {
            Data.ListLesson.Add(new Lesson(type, trainerId, target_audience, day, start, during, enumLevel));
        }

        // PUT api/<LessonController>/5
        [HttpPut("{code}")]
        public void Put(int code,EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel)
        {
            Lesson l = Data.ListLesson.SingleOrDefault(l => l.Code == code);
            l.Type=type;
            l.TrainerId = trainerId;
            l.Target_audience = target_audience;
            l.Day = day;
            l.Start = start;
            l.During = during;
            l.EnumLevel = enumLevel;
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{code}")]
        public void Delete(int code)
        {
            Data.ListLesson.Remove(Data.ListLesson.SingleOrDefault(l => l.Code == code));
        }
    }
}
