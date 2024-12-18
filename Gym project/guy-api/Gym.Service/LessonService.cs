﻿using Gym.Core.Entities;
using Gym.Core.Repositories;
using Gym.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Service
{
    public class LessonService:ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;   
        }
        public List<Lesson> GetAll()
        {
            return _lessonRepository.GetAll();
        }
        public List<Lesson> GetByDay(Weekday day)
        {
            return _lessonRepository.GetByDay(day);
        }
        public List<Lesson> Get(Weekday day, EnumTypeOfFitness typesOfFitness)
        {
            return _lessonRepository.Get(day, typesOfFitness);  
        }

        public void Post(int id,EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel)
        {
            _lessonRepository.Post(id , type, trainerId, target_audience, day, start, during, enumLevel);
        }

        public void Put(int id, EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel)
        {
            _lessonRepository.Put(id, type,  trainerId,  target_audience,  day,  start,  during,  enumLevel);
        }
        public void Delete(int id)
        {
            _lessonRepository.Delete(id);
        }
    }
}
