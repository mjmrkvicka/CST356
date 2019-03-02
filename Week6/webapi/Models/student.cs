namespace Models {
    public class Student {

        public Student(int studentId, string emailAddress)
        {
            this.StudentId = studentId;
            this.EmailAddress = emailAddress;
        }
        public int StudentId {get; set;}
        public string EmailAddress {get; set; }
    }    
}