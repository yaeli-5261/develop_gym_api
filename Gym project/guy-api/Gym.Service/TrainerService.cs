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
    public class TrainerService:ITrainerService
    {
        private readonly ITrainerRepository _trainerRepository;

        public TrainerService(ITrainerRepository trainerRepository)
        {
            _trainerRepository = trainerRepository;   
        }

        public List<Trainer> GetAll()
        {
            return _trainerRepository.GetAll();
        }
        public Trainer GetById(string id)
        {
            return _trainerRepository.GetById(id);
        }
        public void Post(string id, string FirstName, string LastName, EnumGender Gender, String Phon, String Mail, EnumTypeOfFitness TypeOfFitness)
        {
            _trainerRepository.Post(id, FirstName, LastName, Gender, Phon, Mail, TypeOfFitness);
        }
        public void Put(string id, string FirstName, string LastName, EnumGender Gender, String Pel, String Mail, EnumTypeOfFitness TypeOfFitness)
        {
            _trainerRepository.Put(id, FirstName, LastName, Gender, Pel, Mail, TypeOfFitness); 

        }
        public void PutActive(string id, bool isActiveTrainer)
        {
            _trainerRepository.PutActive(id, isActiveTrainer);
        }
        public void Delete(string id)
        {
            _trainerRepository.Delete(id);
        }
    }
}
