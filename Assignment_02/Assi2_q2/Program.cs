using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi2_q2
{
    public class Student
    {
        private string Name;
        private int Age;


        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name+" "+ Age;
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] s = CreateArray();
            AcceptInfo(s);
            PrintInfo(s);

            Student[] reversedStudents = ReverseArray(s);
            PrintInfo(reversedStudents);
        }
    
    static Student[] CreateArray()
        {
            Console.WriteLine("Enter no. of students: ");
            int nStud = int.Parse(Console.ReadLine());
            return new Student[nStud];
        }
        static void AcceptInfo(Student[] s)
        {
            for (int i = 0; i < s.Length; i++) {
                Console.WriteLine("Enter details of Students: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                s[i] = new Student(name, age);
            }
        }

        static void PrintInfo(Student[] s)
        {
            Console.WriteLine("Students Information: ");
            foreach (Student student in s) Console.WriteLine(student);
        }

        static Student[] ReverseArray(Student[] s)
        {
            Student[] reversedStudent = new Student[s.Length];
            for (int i = 0; i < reversedStudent.Length; i++) {
                reversedStudent[i] = s[s.Length - 1 - i];
            }
            return reversedStudent;
        }

    }
}
