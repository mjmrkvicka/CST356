namespace Models {
    public class Student {

        public Student(int id, string email)
        {
            this.id = id;
            this.email = email;
        }
        public int id {get; set;}
        public string email {get; set; }
    }    
}