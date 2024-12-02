using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Services
{
    public interface IClientService
    {
        List<Client> GetAll();

        Client GetById(string id);

        public void Post(string id, string firstName, string lastName, EnumGender gender, string pel, string mail, EnumhealthFund enumhealthFund);

        //public void post( Client c);

        public void Put(string id, string firstName, string lastName, EnumGender gender, String Pel, String Mail, EnumhealthFund enumhealthFund);

        public void Delete(string id);


    }
}
