using guy_api.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace guy_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
      
        // GET: api/<TrainerController>
        [HttpGet]
       
        public ActionResult Get()
        {
            return Ok(Data.ListTrainer);
        }
        // GET api/<TrainerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            foreach(var trainer in Data.ListTrainer)
            {
                  if(trainer.Id==id)
                    return Ok(trainer);
            }
            return NotFound("id not valid");
        }

        // POST api/<TrainerController>
        [HttpPost]
     
        public void Post(string id, string FirstName, string LastName, EnumGender Gender, String Phon, String Mail, EnumTypeOfFitness TypeOfFitness)
        {
            Data.ListTrainer.Add(new Trainer(id, FirstName, LastName, Gender, Phon, Mail, TypeOfFitness));
        }

        // PUT api/<TrainerController>/5

        [HttpPut("{id}")]
        public void Put(string id,string FirstName, string LastName, EnumGender Gender, String Pel, String Mail, EnumTypeOfFitness TypeOfFitness)
        {
            Trainer trainer = Data.ListTrainer.SingleOrDefault(t => t.Id == id);
            if (trainer == null) 
            { NotFound("id not valid"); }
            else
            {
                trainer.FirstName = FirstName;
                trainer.LastName = LastName;
                trainer.Pel = Pel;
                trainer.Mail = Mail;
                trainer.TypeOfFitness = TypeOfFitness;
            }
        }

        [HttpPut("{id}/{isActiveTrainer}")]

        public void Put(string id, bool isActiveTrainer)
        {
              Data.ListTrainer.SingleOrDefault(t=>t.Id==id).IsActiveTrainer=isActiveTrainer;
        }

        // DELETE api/<TrainerController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Data.ListTrainer.Remove(Data.ListTrainer.SingleOrDefault(t => t.Id == id));
        }
    }
}
