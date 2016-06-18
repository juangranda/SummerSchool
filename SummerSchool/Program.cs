using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        public static string[] studentList = new string[15];

        static void Main(string[] args)
        {
            Menu();
            GetChoice();
               
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
        public static void MenuWithoutClear()
        {
            Console.WriteLine();
            Console.WriteLine("1) Enroll a student");
            Console.WriteLine("2) Unenroll a student");
            Console.WriteLine("3) Print out the list of enrolled students");
            Console.WriteLine("4) Exit");
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
            Console.WriteLine();
            string newStudent = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(newStudent + " has been enrolled and will need to pay £200");
            Console.WriteLine();
            Console.WriteLine("     Press any key to return to main menu");
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
            string unenrolledStudent = Console.ReadLine();
            Console.WriteLine(unenrolledStudent + " has been unenrolled");
            Console.WriteLine();
            Console.WriteLine("Press any key to return to main menu");
            Console.WriteLine();
            Console.ReadKey();
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
        public static bool Is4(string choice)
        {
            if (choice == "4")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void Option4()
        {
            Console.Clear();
            Console.WriteLine("Press any key to exit");
        }
        public static bool GetChoice()
        {
            string choice = Console.ReadLine();
            while (!(choice == "1" || choice == "2" || choice == "3" || choice == "4"))
            {
                Console.WriteLine();
                Console.WriteLine("*** Invalid Choice ***");
                Console.WriteLine();
                Console.WriteLine("Please select options from the menu. (Valid choices are 1, 2, 3, 4)");
                Console.WriteLine();
                MenuWithoutClear();
                choice = Console.ReadLine();
            }

            Console.WriteLine();
            if (Is1(choice) == true)
            {
                Option1();
                Console.WriteLine();
                Menu();
                GetChoice();
                return true;
            }
            else if (Is2(choice) == true)
            {
                Option2();
                Console.WriteLine();
                Menu();
                GetChoice();
                return true;
            }
            else if (Is3(choice) == true)
            {
                Option3(studentList);
                Console.WriteLine();
                MenuWithoutClear();
                GetChoice();
                return true;
            }
            else if (Is4(choice) == true)
            {
                Option4();
                return true;
            }
            else
            {
                return false;
            }

        }
            /*Console.WriteLine("Invalid Choice");
            Console.WriteLine("Please select options from the menu. Valid choices are 1, 2, 3, 4");
            Console.WriteLine();
            string choice = Console.ReadLine(); 
            if (choice == "1")
            {
                Console.WriteLine();
                Option1();
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                Option2();
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                Option3(studentList);
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Option4();
            }*/
       
    }
}
