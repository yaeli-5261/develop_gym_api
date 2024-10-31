namespace guy_api.Entities
{
    public enum EnumhealthFund
    {
        Clalit, Maccabi, Meuhedet, Leumit
    }
    public class Client
    {
        private static int count = 0;
        public int Code {  get;  }//primery key
        public string Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public string Pel { get; set; }
        public string Mail { get; set; }
        public Enum EnumhealthFund { get; set; }//קופח
        public bool IsActiveClient { get; set; }  //status
        public List<Lesson> ClientLesson { get; set; }//אימונים שבהם משתתף המתאמן

        public Client(string id, string firstName, string lastName, EnumGender gender, string pel, string mail, Enum enumhealthFund)
        {
            Code = ++count;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Pel = pel;
            Mail = mail;
            EnumhealthFund = enumhealthFund;
            IsActiveClient= true; 
            ClientLesson = new List<Lesson> ();
        }
        public Client()
        {
            
        }
    }
}
