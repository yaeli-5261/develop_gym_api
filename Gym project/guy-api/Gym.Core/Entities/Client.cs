using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Core.Entities
{
    public enum EnumhealthFund
    {
        Clalit, Maccabi, Meuhedet, Leumit
    }
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public string Pel { get; set; }
        public string Mail { get; set; }
        public EnumhealthFund EnumhealthFund { get; set; }//קופח
        public bool IsActiveClient { get; set; }  //status
        public List<Lesson> ClientLesson { get; set; }//אימונים שבהם משתתף המתאמן

        public Client(int id, string firstName, string lastName, EnumGender gender, string pel, string mail, EnumhealthFund enumhealthFund)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Pel = pel;
            Mail = mail;
            EnumhealthFund = enumhealthFund;
            IsActiveClient = true;
            ClientLesson = new List<Lesson>();
        }
        public Client()
        {

        }
    }
}
