


using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP1{
    
    public class OOP1
    {

        public enum WeekDays
        {
            Sunday=1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        public struct Person 
        {
            public string Name;
            public int age;

            public Person(string _Name,int Age)
            {
                Name = _Name;
                age = Age;
            }


            override
            public string ToString()
            {
                return $"Name:{Name} \nAge: {age}\n";
            }

        }

        public enum Season 
        {
            spring, summer, autumn, winter,permission
        }

        public enum Permission : byte
        {
            Read = 1, Write = 2, Delete = 4, Execute = 8
        }

        public enum Colors
        {
            Red = 1,
            Green = 2,
            Blue = 3,
            None=0
        }
        int counter = 1,pow=1;
        
        public struct Point
        {
            public double x;
            public double y;

            public Point(double x, double y) 
            {
                this.x = x;
                this.y = y;
            }


        }

        static void Main(string[] args)
        {
            #region Enum WeekDays
            ////Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.
            //WeekDays days = WeekDays.Sunday;

            //Console.WriteLine(WeekDays.Sunday);
            //Console.WriteLine(WeekDays.Monday);
            //Console.WriteLine(WeekDays.Tuesday);
            //Console.WriteLine(WeekDays.Wednesday);
            //Console.WriteLine(WeekDays.Thursday);
            //Console.WriteLine(WeekDays.Friday);
            //Console.WriteLine(WeekDays.Saturday);

            #endregion

            #region Struct Person
            //Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array.

            //Person p1 = new Person("Abdelrahman",20);
            //Person p2 = new Person("Gaber", 22);
            //Person p3 = new Person("Mohamed", 15);

            //Person[] person= new Person[] {p1,p2,p3};

            //for (int i = 0; i < person.Length; i++) 
            //{
            //    Console.WriteLine(person[i].ToString());
            //}

            #endregion

            #region Enum Season
            //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Input a Season name");
            //bool statement = false;

            //do
            //{
            //    string userInput = Console.ReadLine().ToLower();

            //    if (Enum.TryParse(typeof(Season), userInput,true,out object result)){
            //        Console.WriteLine(result);
            //        statement = true;
            //        if ((Season)result == Season.spring)
            //        {
            //            Console.WriteLine("March to May");
            //            break;
            //        }
            //        if ((Season)result == Season.summer)
            //        {
            //            Console.WriteLine("june to august");
            //            break;

            //        }
            //        if ((Season)result == Season.autumn)
            //        {
            //            Console.WriteLine("September to November");
            //            break;

            //        }
            //        if ((Season)result == Season.winter)
            //        {
            //            Console.WriteLine("December to February");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please input a valid Season");
            //    }

            //}while(statement);


            #endregion

            #region Permission Enum
            //Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //Permission var =  Permission.Write | Permission.Delete | Permission.Execute;
            //Console.WriteLine(var); 
            //Console.WriteLine(typeof(var & Permission.Read));




            #endregion

            #region Colors Enum


            //Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.WriteLine("Please Enter a color");
            //Colors color = Colors.None;

            //try
            //{
            //    Enum.TryParse(typeof(Colors), Console.ReadLine(), true, out object? result);
            //    color = (Colors) result;
            //    if (color == Colors.Red || color == Colors.Blue || color == Colors.Green)
            //    {
            //        Console.WriteLine($"{result} is a primary color");
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
            //finally 
            //{
            //    Console.WriteLine($"{color} is NOT a primary color");
            //}


            #endregion

            #region Struct Distance between two points
            //Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter First Point");
            //Console.WriteLine("Enter Point X");
            //double inputX_1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point Y");
            //double inputY_1 = double.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Enter Second Point");
            //Console.WriteLine("Enter Point X");
            //double inputX_2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point Y");
            //double inputY_2 = double.Parse(Console.ReadLine());
            //Console.Clear();

            //Point p1 = new Point(inputX_1, inputY_1);
            //Point p2 = new Point(inputX_2, inputY_2);

            //Console.WriteLine(Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2)));





            #endregion

            #region Oldest Person Struct

            //Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person p1 = new Person("Abdelrahman",20);
            //Person p2 = new Person("Gaber", 22);
            //Person p3 = new Person("Mohamed", 22);

            //Person[] person= new Person[] {p1,p2,p3};
            //int max = 0;


            //for (int i = 0; i < person.Length; i++) 
            //{
            //    if(max < person[i].age)
            //    {
            //        max = person[i].age;
            //    }
            //}

            //for (int i = 0; i < person.Length; i++)
            //{
            //    if (person[i].age == max)
            //    {
            //        Console.WriteLine(person[i].ToString());
            //    }

            //}


            #endregion 


        }
    }

}