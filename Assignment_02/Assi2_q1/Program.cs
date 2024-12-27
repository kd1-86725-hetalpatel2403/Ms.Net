using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_02
{
    public class Program{ 
        static void Main (string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();

        }
    }

    public struct Student
    {
        private string Name;
        private bool Gender;
        private int Age;
        private int Std;
        public char Div;
        private double Marks;

        //public Student()
        //{
        //    Name = string.Empty;
        //    Gender = true;
        //    Age = 0;
        //    Std = 0;
        //    Div = 'H';
        //    Marks = 0.0;

        //}
        public Student(string name,bool gender,int age, int std, char div, double marks)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Std = std;
            Div = div;
            Marks = marks;
        }

        public double _Marks
        {
            get { return Marks; }
            set { Marks = value; }
        }
        public char _Div
        {
            get { return Div; }
            set { Div = value; }
        }
        public int _Std
        {
            get { return Std; }
            set { Std = value; }
        }
        public int _Age
        {
            get { return Age; }
            set { Age = value; }
        }


        public bool _Gender
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }


        public void AcceptDetails()
        {
            Console.WriteLine("Enter your Name: ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter your Gender: (true for female and false for male)");
            this.Gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter your Age: ");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Standard: ");
            this.Std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Division: ");
            this.Div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your Marks: ");
            this.Marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            //return Name.ToString() + " " + Gender.ToString() + " " + Age.ToString() + " "  + Std.ToString()  + " " + Div.ToString() + " " + Marks.ToString();   
            Console.WriteLine("Name:"+ Name);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Standard:" + Std);
            Console.WriteLine("Division:" + Div);
            Console.WriteLine("Marks:" + Marks);
        }

    }
}
