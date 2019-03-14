using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Database.Entities;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public List<StudentDto> GetAllStudents()
    {
        var studentDtos = new List<StudentDto>();

        foreach(var student in _studentRepository.GetAllStudents())
        {
            studentDtos.Add(new StudentDto {
                Special = isSpecial(student)
            });
        }

        return studentDtos;
    }

    private bool isSpecial(Student student)
    {
        string firstName = student.Person.FirstName;

        return (firstName.Contains('Z') || firstName.Contains('z'));
    }
}