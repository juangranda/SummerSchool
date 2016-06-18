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
            string[] studentList = new string[15];
            
            Menu();

            string choice = Console.ReadLine();
            MenuChoice(choice);
            if (Is1(choice) == true)
            {
                Option1();
                Console.WriteLine();
                Menu();
            }
            else if (Is2(choice) == true)
            {
                Option2();
            }
            else if (Is3(choice) == true)
            {
                Option3(studentList);
            }
               
            Console.ReadKey();
        }
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine();
            Console.WriteLine("1) Enroll a student");
            Console.WriteLine("2) Unenroll a student");
            Console.WriteLine("3) Print out the list of enrolled students");
            Console.WriteLine("4) Exit");
            Console.WriteLine();
            Console.WriteLine("ENTER A NUMBER THAT CORRESPONDS TO YOUR CHOICE IN THE MENU:");
            Console.WriteLine();
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
            string newStudent = Console.ReadLine();
            Console.WriteLine(newStudent + " has been enrolled and will need to pay £200");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static bool Is2(string choice)
        {
            if (choice == "2")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void Option2()
        {
            Console.WriteLine("Please enter the name of the student you want to unenroll");
        }

        public static bool Is3(string choice)
        {
            if (choice == "3")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void Option3(string[] studenList)
        {
            for (int i = 0; i < studenList.Length; i++)
            {
                Console.WriteLine(studenList[i]);
            }
        }

    }
}
