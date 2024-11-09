using guy_api.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace guy_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        // GET: api/<ClientController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(Data.ListClient);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {

            foreach (var client in Data.ListClient)
            {
                if (client.Id == id)
                    return Ok(client);
            }
            return NotFound("The id client isn'c valid");
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post(string id, string firstName, string lastName, EnumGender gender, string pel, string mail, EnumhealthFund enumhealthFund)
        {
            Data.ListClient.Add(new Client(id, firstName, lastName, gender, pel, mail, enumhealthFund));
        }

        //public void post ([FromBody]Client c)
        //{
        //    Data.ListClient.Add(new Client {Id=c.Id, FirstName=c.FirstName,LastName=c.LastName,Gender=c.Gender,Pel=c.Pel,Mail=c.Mail,EnumhealthFund=c.EnumhealthFund});
        //}

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(string id, string firstName, string lastName, EnumGender gender ,String Pel, String Mail, EnumhealthFund enumhealthFund)
        {
            Client c=Data.ListClient.SingleOrDefault(c => c.Id == id);
            if (c != null)
            {
                c.FirstName = firstName;
                c.LastName = lastName;
                c.Pel = Pel;
                c.Mail = Mail;
                c.EnumhealthFund = enumhealthFund;
            }
            else NotFound("not valid");
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Data.ListClient.Remove(Data.ListClient.SingleOrDefault(c => c.Id == id));
        }
    }
}
