using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Services
{
    public interface ITrainerService
    {
        public List<Trainer> GetAll();

        public Trainer GetById(string id);

        public void Post(string id, string FirstName, string LastName, EnumGender Gender, String Phon, String Mail, EnumTypeOfFitness TypeOfFitness);

        public void Put(string id, string FirstName, string LastName, EnumGender Gender, String Pel, String Mail, EnumTypeOfFitness TypeOfFitness);

       public void PutActive(string id, bool isActiveTrainer);

        public void Delete(string id);
    }
}
