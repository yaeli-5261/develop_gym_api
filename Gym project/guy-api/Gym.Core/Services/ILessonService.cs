using Gym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Services
{
    public interface ILessonService
    {
        public List<Lesson> GetAll();

        public List<Lesson> GetByDay(Weekday day);

        public List<Lesson> Get(Weekday day, EnumTypeOfFitness typesOfFitness);

        public void Post(EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel);
        public void Put(int code, EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel);
        public void Delete(int code);

    }
}
