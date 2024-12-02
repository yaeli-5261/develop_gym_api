namespace Gym.Core.Entities
{

    public enum Weekday
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
    }
    public enum EnumLevel
    {
        beginner,
        advanced,
    }

    public class Lesson
    {

        private static int count = 0;
        public int Code { get; }//primery key
        public EnumTypeOfFitness Type { get; set; } //type guy
        public string TrainerId { get; set; }
        public EnumGender Target_audience { get; set; }
        public Weekday Day { get; set; }
        public TimeSpan Start { get; set; }
        public int During { get; set; }//in minutes
        public TimeSpan End { get; set; }
        public EnumLevel EnumLevel { get; set; }

        public Lesson(EnumTypeOfFitness type, string trainerId, EnumGender target_audience, Weekday day, TimeSpan start, int during, EnumLevel enumLevel)
        {
            Code = ++count;
            Type = type;
            TrainerId = trainerId;
            Target_audience = target_audience;
            Day = day;
            Start = start;
            During = during;
            End = start.Add(TimeSpan.FromMinutes(During));
            EnumLevel = enumLevel;
        }
        public Lesson()
        {

        }

    }
}
