
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using Database.Entities;
using System;
using System.Diagnostics;

public class StudentServiceTests
{
    private StudentService _studentService; 
    private IStudentRepository _studentRepository;

    [SetUp]
    public void Setup()
    {
        var loggerFactory = A.Fake<LoggerFactory>();
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void NoSpecialStudents()
    {
        // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    StudentId = 1,
                    EmailAddress = "test1@gmail.com",
                    PersonId = 1,
                    Person = new Person {
                        PersonId = 1,
                        FirstName = "Michael",
                        MiddleName = "Tyrone",
                        LastName = "Smith"
                    }     
                },
                new Student {
                    StudentId = 2,
                    EmailAddress = "test2@gmail.com",
                    PersonId = 2,
                    Person = new Person {
                        PersonId = 2,
                        FirstName = "Bob",
                        MiddleName = "Andrew",
                        LastName = "Jones"
                    }     
                },
            }
        );

        // Act
        var studentDtos = _studentService.GetAllStudents();

        // Assert (NUnit Assertions)
        Assert.That(studentDtos.Any(sdto => sdto.Special), Is.EqualTo(false));

        // Assert (FluentAssertions)
        studentDtos.Any(sdto => sdto.Special).Should().BeFalse();
    }

    [Test]
    public void OneOrMoreSpecialStudents()
    {
        try
        {
            // Arrange
            A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
                new List<Student> {
                    new Student {
                        StudentId = 1,
                        EmailAddress = "test1@gmail.com",
                        PersonId = 1,
                        Person = new Person {
                            PersonId = 1,
                            FirstName = "Papa",
                            MiddleName = "Tyrone",
                            LastName = "Smith"
                        }     
                    },
                    new Student {
                        StudentId = 2,
                        EmailAddress = "test2@gmail.com",
                        PersonId = 2,
                        Person = new Person {
                            PersonId = 2,
                            FirstName = "Bob",
                            MiddleName = "Andrew",
                            LastName = "Jones"
                        }     
                    },
                }
            );

            // Act
            var studentDtos = _studentService.GetAllStudents();

            // Assert (NUnit Assertions)
            Assert.That(studentDtos.Single(sdto => sdto.Special).Special, Is.EqualTo(true));

            // Assert (FluentAssertions)
            studentDtos.Single(sdto => sdto.Special).Special.Should().Be(true);
        }
        catch (InvalidOperationException ex)
        {
            throw new Exception("\n Expected: 1 or more special students.\n Found: 0 special students");
        }
    }
}