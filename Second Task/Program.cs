using System;

namespace Second_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.DisplayInfo();
            Console.Write("Sudent's Marks is -> ");
            foreach (int i in student.Marks)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nAverageGrade is -> " + student.AverageGrade +"\n");

            Employee employee = new Employee();
            employee.DisplayInfo();
            Console.WriteLine($"Salary is -> {employee.Salary}\nChanged salary -> " + employee.CalculateTax());

            Teacher teacher = new Teacher();
            teacher.DisplayInfo();
            Console.WriteLine($"HourlyRate -> {teacher.HourlyRate}\nSalary ->" + teacher.CalculateMonthlyIncome());
            
        }
    }



    class Person
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nId -> {Id}\nFullName -> {FullName}\nPhoneNumber -> {PhoneNumber}");
        }

    }
    class Student : Person
    {
        public int AverageGrade { get; set; }
        public int[] Marks { get; set; }

        public Student()
        {
            Id = "112a";
            FullName = "Javlon Alimov";
            PhoneNumber = "+99890-181-66-77";
            Marks = new int[5] { 3, 5, 4 , 3 , 5 };

            int sum = 0;
            foreach(int i in Marks)
            {
                sum += i;
            }
            AverageGrade = sum / Marks.Length;
        }

    }

    class Employee : Person
    {
        public decimal Salary { get; set; }

        public Employee()
        {
            Id = "444a";
            FullName = "Muhammad Mangitov";
            PhoneNumber = "+99891-166-22-56";
            Salary = 3_000;
        }

        public decimal CalculateTax()
        {
            return Salary / 100 * 113;
        }
    }

    class Teacher : Person
    {
        public int HourlyRate { get; set; }

        public Teacher()
        {
            Id = "344";
            FullName = "Shohboz Xurramov";
            PhoneNumber = "+99890-344-11-51";
            HourlyRate = 30;
        }

        public decimal CalculateMonthlyIncome()
        {
            return 16 * HourlyRate;
        }
    }
}