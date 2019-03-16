using Database.Entities;

public class StudentDto 
{
    public long StudentId { get; set; }
    public string EmailAddress { get; set; }
    public Person Person { get; set; }
    public bool Special { get; set;}
}