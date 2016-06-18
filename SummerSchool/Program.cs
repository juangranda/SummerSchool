using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

            string choice = Console.ReadLine();
            MenuChoice(choice);
            if (Is1(choice) == true)
            {
                Option1();
            }

               
            Console.ReadKey();
        }
        public static void Menu()
        {
            Console.WriteLine("1) Enroll a student");
            Console.WriteLine("2) Unenroll a student");
            Console.WriteLine("3) Print out the list of enrolled students");
            Console.WriteLine("4) Exit");
        }

        public static string MenuChoice(string choice)
        {
            return choice;
        }

        public static bool Is1(string choice)
        {
            if (choice == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void Option1()
        {
            Console.WriteLine("Please enter the name of the student you want to enroll");
        }

    }
}
