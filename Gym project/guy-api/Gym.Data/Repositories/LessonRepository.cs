using Gym.Core.Entities;
using Gym.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Data.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly DataContext _context;
        public LessonRepository(DataContext context)
        {
            _context = context;
        }
        public List<Lesson> GetAll()
        {
            return _context.ListLesson;
        }
        public List<Lesson> GetByDay(Weekday day)
        {
            return _context.ListLesson.Where(l => l.Day == day).ToList();
        }

        public List<Lesson> Get(Weekday day, EnumTypeOfFitness typesOfFitness)
        {
            return _context.ListLesson.Where(l => l.Day == day && l.Type == typesOfFitness).ToList();
        }
        public void Post(EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel)
        {
            _context.ListLesson.Add(new Lesson(type, trainerId, target_audience, day, start, during, enumLevel));
        }
        public void Put(int code, EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel)
        {
            Lesson l = _context.ListLesson.SingleOrDefault(l => l.Code == code);
            if (l != null)
            {
                l.Type = type;
                l.TrainerId = trainerId;
                l.Target_audience = target_audience;
                l.Day = day;
                l.Start = start;
                l.During = during;
                l.EnumLevel = enumLevel;
            }

        }
        public void Delete(int code)
        {
            _context.ListLesson.Remove(_context.ListLesson.SingleOrDefault(l => l.Code == code));
        }

    }
}
