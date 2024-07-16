using System;

namespace rendom5
{
    public class Student : Person
    {
        public int Grade { get; set; }

        public Student(string name, int age, int grade)
            : base(name, age)
        {
            Grade = grade;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"Subject: {Subject}");
        }
    }
}
