using System.Collections.Generic;
using Models;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> students = new List<Student>
        {
            new Student(12958073, "student1@oit.edu"),
            new Student(78463720, "student2@oit.edu"),
            new Student(90128473, "student3@oit.edu"),
            new Student(39872048, "student4@oit.edu"),
            new Student(98759473, "student5@oit.edu"),
        };

        public static List<Person> persons = new List<Person>
        {
            new Person("Person", "T", "One"),
            new Person("Person", "J", "Two"),
            new Person("Person", "K", "Three"),
            new Person("Person", "S", "Four"),
            new Person("Person", "M", "Five")
        };
    }
}