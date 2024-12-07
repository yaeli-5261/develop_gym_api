using Gym.Core.Entities;
using Gym.Core.Repositories;
using Gym.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Service
{
    public class ClientService:IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;   
        }
        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }
        public Client GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void Post(int id, string firstName, string lastName, EnumGender gender, string pel, string mail, EnumhealthFund enumhealthFund)
        {
             _clientRepository.Post(id,  firstName,  lastName,  gender,  pel,  mail,  enumhealthFund);
        }
        public void Put(int id, string firstName, string lastName, EnumGender gender, String Pel, String Mail, EnumhealthFund enumhealthFund)
        {
            _clientRepository.Put(id, firstName, lastName, gender, Pel, Mail, enumhealthFund);
        }
        //public void post([]Client c)
        //{
        //    _clientRepository.post(c);
        //}
        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }


    }
}
