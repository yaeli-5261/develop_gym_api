
using Gym.Core.Entities;
using Gym.Core.Interface;
using Gym.Core.Services;
using Gym.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace guy_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService; 
        }

        // GET: api/<ClientController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_clientService.GetAll());
        }

        //// GET api/<ClientController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            return Ok(_clientService.GetById(id));
        }

        //// POST api/<ClientController>
        [HttpPost]
        public void Post(string id, string firstName, string lastName, EnumGender gender, string pel, string mail, EnumhealthFund enumhealthFund)
        {
            _clientService.Post(id, firstName,  lastName, gender,  pel,  mail,  enumhealthFund);
            
        }
        //[HttpPost("{c}")]
        //public void Post(Client c)
        //{
        //     _clientService.Post(c);
        //}

        //// PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public void Put(string id, string firstName, string lastName, EnumGender gender, String Pel, String Mail, EnumhealthFund enumhealthFund)
        {
            _clientService.Put(id, firstName, lastName, gender, Pel, Mail, enumhealthFund);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _clientService.Delete(id);
        }
    }
}
