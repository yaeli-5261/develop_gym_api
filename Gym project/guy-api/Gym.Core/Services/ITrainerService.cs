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

        public Trainer GetById(int id);

        public void Post(int id, string FirstName, string LastName, EnumGender Gender, String Phon, String Mail, EnumTypeOfFitness TypeOfFitness);

        public void Put(int id, string FirstName, string LastName, EnumGender Gender, String Pel, String Mail, EnumTypeOfFitness TypeOfFitness);

       public void PutActive(int id, bool isActiveTrainer);

        public void Delete(int id);
    }
}
