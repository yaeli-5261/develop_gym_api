using Gym.Core.Entities;
using Gym.Core.Interface;

namespace Gym.Data
{
    public class DataContext : IDataContext
    {
        public List<Trainer> ListTrainer { get; set; }
        public List<Client> ListClient { get; set; }
        public List<Lesson> ListLesson { get; set; }

        public DataContext()
        {
            ListTrainer = new List<Trainer>() {
              new Trainer("1","yaeli","naaman",EnumGender.female,"0556765261","yaelina5261@gmail.com",EnumTypeOfFitness.Pilates),
              new Trainer("2","shosi","levi",EnumGender.female,"05485432135","tamar36603@gmail.com", EnumTypeOfFitness.Pilates),
             };
            ListLesson = new List<Lesson>()
        {
           new Lesson(EnumTypeOfFitness.Pilates,"1", EnumGender.female,Weekday.Monday,new TimeSpan(20,30,0),45,EnumLevel.advanced),
           new Lesson(EnumTypeOfFitness.Dance,"2", EnumGender.female,Weekday.Monday ,new TimeSpan(22,15,0),45,EnumLevel.beginner),
           new Lesson(EnumTypeOfFitness.HIIT,"3", EnumGender.male,Weekday.Sunday,new TimeSpan(18,45,0),45,EnumLevel.advanced)
        };
            ListClient = new List<Client>()
        {
            new Client("1","eti","choen",EnumGender.female,"111111","fffffff",EnumhealthFund.Clalit),
            new Client("2","ruti","naaman",EnumGender.female,"22222222","jjjjjjjjj",EnumhealthFund.Leumit),
            new Client("3","ayala","levi",EnumGender.male,"33333333","@gmail.com",EnumhealthFund.Maccabi),
        };
        }
    }
}
