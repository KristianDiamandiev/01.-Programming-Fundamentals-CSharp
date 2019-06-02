using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }

    static Student NewStudent()
    {
        Student OneStudent = new Student();
        string[] input = Console.ReadLine().Split(' ').ToArray();
        OneStudent.Name = input[0];
        OneStudent.Grades = input.Skip(1).Select(double.Parse).ToList();
        return OneStudent;
    }

    static void Main()
    {
        List<Student> students = new List<Student>();
        int numOfStudents = int.Parse(Console.ReadLine());
        while (numOfStudents-- != 0)
        {
            students.Add(NewStudent());
        }

        foreach (var st in students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
        {
            if (st.AverageGrade >= 5.00)
                Console.WriteLine($"{st.Name:F2} -> {st.AverageGrade:F2}");
        }
    }
}

