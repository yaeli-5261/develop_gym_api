namespace guy_api.Entities
{
    public enum EnumGender{male, female};
    public enum EnumTypeOfFitness {HIIT, Aerobics, Pilates,Dance, FloorExercise ,Yoga};
    public class Trainer
    {
        private static int count = 0;
        public int Code { get; }//primery key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public string Id { get; set; }
        public string Pel { get; set; }
        public string Mail { get; set; }
        public /*List<*/ EnumTypeOfFitness TypeOfFitness { get; set; }
        public bool IsActiveTrainer { get; set; }  //status
        public List<Lesson> TrainerLesson { get; set; }//השעור של המאמן

        public Trainer(string id, string firstName, string lastName, EnumGender gender, string pel, string mail, EnumTypeOfFitness typeOfFitness)
        {
            Code = ++count;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Pel = pel;
            Mail = mail;
            TypeOfFitness=typeOfFitness;
            IsActiveTrainer = true;
            TrainerLesson = new List<Lesson>();

        }
    }
    
}
