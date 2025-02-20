using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6Ex2
{
    class Student //create student class
    {
        //declarations
        string name;
        int id;
        int age;
        string course;

        public Student() //default constructor
        {
            //default values for student
            name = "kolton";
            id = 0542112;
            age = 27;
            course = "CIS";
        }

        public Student(string name, int id, int age, string course) //create custom constructor
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.course = course;
        }

        public void DisplayStudentDetails() //method to display all details
        {
            //print statements 
            Console.WriteLine("name: " + name);
            Console.WriteLine("id: " + id);
            Console.WriteLine("age: " + age);
            Console.WriteLine("course: " + course);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(); //create a default student
            student1.DisplayStudentDetails(); //call method for default student
            Console.WriteLine(); //blank for readability

            Student student2 = new Student("John", 1234567, 20, "Accounting"); //create new customized student
            student2.DisplayStudentDetails(); //call method for default mobilephone
            Console.WriteLine(); //blank for readability

            Student student3 = new Student("Chloe", 7896541, 20, "Nursing"); //create new customized student
            student3.DisplayStudentDetails(); //call method for default mobilephone
            Console.WriteLine(); //blank for readability

            Student student4 = new Student("Kobe", 7895412, 22, "CS"); //create new customized student
            student4.DisplayStudentDetails(); //call method for default mobilephone
            Console.WriteLine(); //blank for readability

        }
    }
}
