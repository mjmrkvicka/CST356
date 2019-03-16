using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database;
using Database.Entities;
using System;

public class StudentRepository: IStudentRepository 
{
    private readonly SchoolContext _dbContext;

    public StudentRepository(SchoolContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<Student> GetAllStudents()
    {
        try
        {
            return _dbContext.Students.Include(s => s.Person).ToList();
        } 
        catch(Exception ex)
        {
            Console.WriteLine("exception: " + ex);
            
            return new List<Student>();
        }
    }

    public Student GetStudentById(long studentId)
    {
        return _dbContext.Students.SingleOrDefault(s => s.StudentId == studentId);
    }

    public void AddStudent(Student student)
    {
        _dbContext.Students.Add(student);
        _dbContext.SaveChanges();
    }

    public void UpdateStudent(Student studentUpdate)
    {
        var student = GetStudentById(studentUpdate.StudentId);

        if (student != null)
        {
            student.EmailAddress = studentUpdate.EmailAddress;
            student.PersonId = studentUpdate.PersonId;
            student.Person = studentUpdate.Person;

            _dbContext.Update(student);

            _dbContext.SaveChanges();
        }
    }

    public void DeleteStudent(long studentId)
    {
        var student = new Student { StudentId = studentId };

        _dbContext.Students.Attach(student);
        _dbContext.Students.Remove(student);
        _dbContext.SaveChanges();
    }
}