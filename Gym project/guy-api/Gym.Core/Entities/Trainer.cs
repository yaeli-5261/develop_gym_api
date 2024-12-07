using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Core.Entities
{
    public enum EnumGender { male, female };
    public enum EnumTypeOfFitness { HIIT, Aerobics, Pilates, Dance, FloorExercise, Yoga };
    public class Trainer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public string Pel { get; set; }
        public string Mail { get; set; }
        public EnumTypeOfFitness TypeOfFitness { get; set; }
        public bool IsActiveTrainer { get; set; }  //status
        public List<Lesson> TrainerLesson { get; set; }//השעור של המאמן

        public Trainer(int id, string firstName, string lastName, EnumGender gender, string pel, string mail, EnumTypeOfFitness typeOfFitness)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Pel = pel;
            Mail = mail;
            TypeOfFitness = typeOfFitness;
            IsActiveTrainer = true;
            TrainerLesson = new List<Lesson>();
        }
    }

}
