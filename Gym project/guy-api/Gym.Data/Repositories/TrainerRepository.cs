using Gym.Core.Entities;
using Gym.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.Repositories
{
    public class TrainerRepository:ITrainerRepository
    {
        private readonly DataContext _context;
        public TrainerRepository(DataContext context)
        {
            _context = context;
        }
        public List<Trainer> GetAll()
        {
            return _context.ListTrainer.ToList()    ;
        }
        public Trainer GetById(int id)
        {
            foreach (var trainer in _context.ListTrainer)
            {
                if (trainer.Id == id)
                  return trainer;
            }
            return null;
        }
        public void Post(int id, string FirstName, string LastName, EnumGender Gender, String Phon, String Mail, EnumTypeOfFitness TypeOfFitness)
        {
            _context.ListTrainer.Add(new Trainer(id, FirstName, LastName, Gender, Phon, Mail, TypeOfFitness));
        }
        public void Put(int id, string FirstName, string LastName, EnumGender Gender, String Pel, String Mail, EnumTypeOfFitness TypeOfFitness)
        {
            Trainer trainer = _context.ListTrainer.SingleOrDefault(t => t.Id == id);
            if (trainer == null)
                return;
            else
            {
                trainer.FirstName = FirstName;
                trainer.LastName = LastName;
                trainer.Pel = Pel;
                trainer.Mail = Mail;
                trainer.TypeOfFitness = TypeOfFitness;
            }
        }
        public void PutActive(int id, bool isActiveTrainer)
        {
            Trainer trainer = _context.ListTrainer.SingleOrDefault(t => t.Id == id);
            if (trainer!= null)
                 trainer.IsActiveTrainer = isActiveTrainer;
        }
        
        public void Delete(int id)
        {
            _context.ListTrainer.Remove(_context.ListTrainer.SingleOrDefault(t => t.Id == id));
        }
    }
}
