using Gym.Core.Entities;
using Gym.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {

        private readonly DataContext _context;

        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public List<Client> GetAll()
        {
            
            return _context.ListClient.ToList();
        }
        public Client GetById(int id)
        {
            foreach (var client in _context.ListClient)
            {
                if (client.Id == id)
                    return client;
            }
            return null;
        }
        public void Post(int id, string firstName, string lastName, EnumGender gender, string pel, string mail, EnumhealthFund enumhealthFund)
        {
            _context.ListClient.Add(new Client(id, firstName, lastName, gender, pel, mail, enumhealthFund));
        }
        public void Post(Client c)
        {
            _context.ListClient.Add(new Client { Id = c.Id, FirstName = c.FirstName, LastName = c.LastName, Gender = c.Gender, Pel = c.Pel, Mail = c.Mail, EnumhealthFund = c.EnumhealthFund });
        }
        public void Put(int id, string firstName, string lastName, EnumGender gender, String Pel, String Mail, EnumhealthFund enumhealthFund)
        {
            Client c = _context.ListClient.SingleOrDefault(c => c.Id == id);
            if (c != null)
            {
                c.FirstName = firstName;
                c.LastName = lastName;
                c.Pel = Pel;
                c.Mail = Mail;
                c.EnumhealthFund = enumhealthFund;
            }
        }
        public void Delete(int id)
        {
            _context.ListClient.Remove(_context.ListClient.SingleOrDefault(c => c.Id == id));

        }
    }
}
