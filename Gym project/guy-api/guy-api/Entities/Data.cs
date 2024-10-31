using guy_api.Controllers;

namespace guy_api.Entities
{
    public static class Data
    {
       public static List<Trainer> ListTrainer = new List<Trainer>()
        {
         new Trainer("1","yaeli","naaman",EnumGender.female,"0556765261","yaelina5261@gmail.com",EnumTypeOfFitness.Pilates),

         new Trainer("2","shosi","levi",EnumGender.female,"05485432135","tamar36603@gmail.com", EnumTypeOfFitness.Pilates),
        };
        public static List<Lesson> ListLesson = new List<Lesson>()
        {
           new Lesson(EnumTypeOfFitness.Pilates,"1", EnumGender.female,Weekday.Monday,new TimeSpan(20,30,0),45,EnumLevel.advanced),
           new Lesson(EnumTypeOfFitness.Dance,"2", EnumGender.female,Weekday.Monday ,new TimeSpan(22,15,0),45,EnumLevel.beginner),
           new Lesson(EnumTypeOfFitness.HIIT,"3", EnumGender.male,Weekday.Sunday,new TimeSpan(18,45,0),45,EnumLevel.advanced)
        };
        public static List<Client> ListClient = new List<Client>()
        {
            new Client("1","eti","choen",EnumGender.female,"111111","fffffff",EnumhealthFund.Clalit),
            new Client("2","eti","grainma",EnumGender.female,"22222222","jjjjjjjjj",EnumhealthFund.Leumit),
            new Client("3","ayala","levi",EnumGender.male,"33333333","@gmail.com",EnumhealthFund.Maccabi),
        };

    }
}
