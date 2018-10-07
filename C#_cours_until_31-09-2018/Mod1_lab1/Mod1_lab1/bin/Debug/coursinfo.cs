using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_lab1
{
    class Class1
    {
        static void Main(string[] args)
        {
            //initialize variables for student information
            string firstName = "";
            string lastName = "";
            DateTime birthday;
            string adress = "";
            string city = "";
            int postal = 0;
            string country = "";
            string degree = "";

            //intialize variables course information
            string courseName = "";
            int credits = 0;
            int numberOfHours = 0;
            string TeacherName = "";

            //assign values to those variables
            lastName = "Snyers ";
            firstName = "Harold ";
            birthday = new DateTime(1998, 6, 23);
            adress = "avenue du polo 9";
            city = "Brussels";
            postal = 1150;
            country = "Belgium";
            degree = "3rd year of bachelor";
            courseName = "Electronics";
            credits = 4;
            numberOfHours = 24;
            TeacherName = "Marchand";

            //some console.wright
            Console.WriteLine("My name is {0}{1}. My birthdate is {2}.", lastName, firstName, birthday);
            Console.WriteLine("my adress is {0} {1} {2} {3}", adress, postal, city, country);
            Console.WriteLine($"I'm doing my {degree} this year, 2018-2019");
            Console.WriteLine("One of my courses is {0}, It's given by {1} and has a value of " +
                "{2} credits. We will have {3} hours of this cours", courseName, TeacherName, credits, numberOfHours);
        }
    }
}