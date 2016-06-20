using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerSchool
{
    class Program
    {
        public static string[] feeArray = { " (£100)", " (£200)" };
        public static bool malfoyBool(string newEnrollment)
        {
            if ((newEnrollment.ToLower()).Contains(studentMalfoy))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string studentMalfoy = "malfoy";
        public static string[] studentList = new string[3];
        public static void studentFee0()
        {
            if (studentList[0].Contains(potter))
            {
                if (!(studentList[0].Contains("£")))
                {
                    studentList[0] = (studentList[0] + feeArray[0]);
                }
                else
                {
                    studentList[0] = studentList[0];
                }
            }
            else
            {
                if (!(studentList[0].Contains("£")))
                {
                    studentList[0] = (studentList[0] + feeArray[1]);
                }
                else
                {
                    studentList[0] = studentList[0];
                }
            }
        }
        public static void studentFee1()
        {
            if (studentList[1].Contains(potter))
            {
                if (!(studentList[1].Contains("£")))
                {
                    studentList[1] = (studentList[1] + feeArray[0]);
                }
                else
                {
                    studentList[1] = studentList[1];
                }
            }
            else
            {
                if (!(studentList[1].Contains("£")))
                {
                studentList[1] = (studentList[1] + feeArray[1]);
                }
                else
                {
                studentList[1] = studentList[1];
                }
            }
        }
        public static void studentFee2()
        {
            if (studentList[2].Contains(potter))
            {
                if (!(studentList[2].Contains("£")))
                {
                    studentList[2] = (studentList[2] + feeArray[0]);
                }
                else
                {
                    studentList[2] = studentList[2];
                }
            }
            else
            {
                if (!(studentList[2].Contains("£")))
                {
                    studentList[2] = (studentList[2] + feeArray[1]);
                }
                else
                {
                    studentList[2] = studentList[2];
                }
            }
        }
        public static void studentFeeList()
        {
            if (studentList[0] != null)
            {
                studentFee0();
            }
            if (studentList[1] != null)
            {
                studentFee1();
            }
            if (studentList[2] != null)
            {
                studentFee2();
            }
        }
        static string potter = "potter";
        static string newEnrollment;
        public static void feesTotal()
        {
           // int studentListLenght = studentList.Length;

            if (studentList[1] == null)
            {
                string fee0Start = studentList[0];
                int fee0StartInt = fee0Start.IndexOf('£');
                fee0StartInt = (fee0StartInt + 1);
                int fee0End = fee0Start.LastIndexOf(')');
                int numberOfDigitsPosition0 = (fee0End - fee0StartInt);
                int feeAmountPosition0 = Convert.ToInt32(fee0Start.Substring(fee0StartInt, numberOfDigitsPosition0));

                int feeAmountTotal = feeAmountPosition0;
                Console.WriteLine("Total: £" + feeAmountTotal);
            }
            else if (studentList[2] == null)
            {
                string fee0Start = studentList[0];
                int fee0StartInt = fee0Start.IndexOf('£');
                fee0StartInt = (fee0StartInt + 1);
                int fee0End = fee0Start.LastIndexOf(')');
                int numberOfDigitsPosition0 = (fee0End - fee0StartInt);
                int feeAmountPosition0 = Convert.ToInt32(fee0Start.Substring(fee0StartInt, numberOfDigitsPosition0));

                string fee1Start = studentList[1];
                int fee1StartInt = fee1Start.IndexOf('£');
                fee1StartInt = (fee1StartInt + 1);
                int fee1End = fee1Start.LastIndexOf(')');
                int numberOfDigitsPosition1 = (fee1End - fee1StartInt);
                int feeAmountPosition1 = Convert.ToInt32(fee1Start.Substring(fee1StartInt, numberOfDigitsPosition1));

                int feeAmountTotal = feeAmountPosition0 + feeAmountPosition1;
                Console.WriteLine("Total: £" + feeAmountTotal);
            }
            else //if (studentList[3] != null)
            {
                string fee0Start = studentList[0];
                int fee0StartInt = fee0Start.IndexOf('£');
                fee0StartInt = (fee0StartInt + 1);
                int fee0End = fee0Start.LastIndexOf(')');
                int numberOfDigitsPosition0 = (fee0End - fee0StartInt);
                int feeAmountPosition0 = Convert.ToInt32(fee0Start.Substring(fee0StartInt, numberOfDigitsPosition0));

                string fee1Start = studentList[1];
                int fee1StartInt = fee1Start.IndexOf('£');
                fee1StartInt = (fee1StartInt + 1);
                int fee1End = fee1Start.LastIndexOf(')');
                int numberOfDigitsPosition1 = (fee1End - fee1StartInt);
                int feeAmountPosition1 = Convert.ToInt32(fee1Start.Substring(fee1StartInt, numberOfDigitsPosition1));

                string fee2Start = studentList[2];
                int fee2StartInt = fee2Start.IndexOf('£');
                fee2StartInt = (fee2StartInt + 1);
                int fee2End = fee2Start.LastIndexOf(')');
                int numberOfDigitsPosition2 = (fee2End - fee2StartInt);
                int feeAmountPosition2 = Convert.ToInt32(fee2Start.Substring(fee2StartInt, numberOfDigitsPosition2));


                int feeAmountTotal = feeAmountPosition0 + feeAmountPosition1 + feeAmountPosition2;
                Console.WriteLine("Total: £" + feeAmountTotal);
            }


            //int feeAmountTotal = feeAmountPosition0 + feeAmountPosition1;
            //Console.WriteLine("Total: £" + feeAmountTotal);
        }

        //public static bool nameArrayLength()
        //{
        //    int studentListLenght = studentList.Length;
        //    if (studentListLenght == 1)
        //    {
        //        return true;
        //    }
        //    else if (studentListLenght == 2)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        static void Main(string[] args)
        {
            Menu();
            GetChoice();
               
            Console.ReadKey();
        }
        public static void Menu()
        {
            if (studentList[0] == null)
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU");
                Console.WriteLine();
                Console.WriteLine("1) Enroll a student");
                Console.WriteLine("3) Print out the list of enrolled students");
                Console.WriteLine("4) Exit");
                Console.WriteLine();
                Console.WriteLine("ENTER A NUMBER THAT CORRESPONDS TO YOUR CHOICE IN THE MENU:");
                Console.WriteLine();
            }
            else if (studentList[2] != null)
            {
                Console.Clear();
                Console.WriteLine("MAIN MENU");
                Console.WriteLine();
                Console.WriteLine("2) Unenroll a student");
                Console.WriteLine("3) Print out the list of enrolled students");
                Console.WriteLine("4) Exit");
                Console.WriteLine();
                Console.WriteLine("ENTER A NUMBER THAT CORRESPONDS TO YOUR CHOICE IN THE MENU:");
                Console.WriteLine();
            }
            else
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
        }
        public static void MenuWithoutClear()
        {
            if (studentList[0] == null)
            {
                Console.WriteLine("MAIN MENU");
                Console.WriteLine();
                Console.WriteLine("1) Enroll a student");
                Console.WriteLine("3) Print out the list of enrolled students");
                Console.WriteLine("4) Exit");
                Console.WriteLine();
                Console.WriteLine("ENTER A NUMBER THAT CORRESPONDS TO YOUR CHOICE IN THE MENU:");
                Console.WriteLine();
            }
            else if (studentList[2] != null)
            {
                Console.WriteLine("MAIN MENU");
                Console.WriteLine();
                Console.WriteLine("2) Unenroll a student");
                Console.WriteLine("3) Print out the list of enrolled students");
                Console.WriteLine("4) Exit");
                Console.WriteLine();
                Console.WriteLine("ENTER A NUMBER THAT CORRESPONDS TO YOUR CHOICE IN THE MENU:");
                Console.WriteLine();
            }
            else
            {
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
            if ((studentList[0]) == null)
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Please enter the name of the student you want to enroll");
                    Console.WriteLine();
                    newEnrollment = Console.ReadLine();
                    if (malfoyBool(newEnrollment))
                    {
                        Console.WriteLine();
                        Console.WriteLine("                   ****** ERROR ******                   ");
                        Console.WriteLine();
                        Console.WriteLine("Students with the last name Malfoy are not to be admitted");
                        Console.WriteLine();
                    }
                    else
                    {

                        studentList[0] = ((newEnrollment).ToLower());
                        if (PotterLastName(newEnrollment))
                        {
                            studentList[0] = (studentList[0]);
                            Console.WriteLine();
                            Console.WriteLine(studentList[0] + " has been enrolled and will need to pay £100");
                        }
                        else
                        {
                            studentList[0] = (studentList[0]);
                            Console.WriteLine();
                            Console.WriteLine(studentList[0] + " has been enrolled and will need to pay £200");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("     *Press any key to return to main menu*");
                Console.WriteLine();
            }
            else if ((studentList[1]) == null)
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Please enter the name of the student you want to enroll");
                    Console.WriteLine();
                    newEnrollment = Console.ReadLine();
                    if (malfoyBool(newEnrollment))
                    {
                        Console.WriteLine();
                        Console.WriteLine("                   ****** ERROR ******                   ");
                        Console.WriteLine();
                        Console.WriteLine("Students with the last name Malfoy are not to be admitted");
                        Console.WriteLine();
                    }
                    else
                    {
                        studentList[1] = ((newEnrollment).ToLower());
                        if (PotterLastName(newEnrollment))
                        {
                            studentList[1] = (studentList[1]);
                            Console.WriteLine();
                            Console.WriteLine(studentList[1] + " has been enrolled and will need to pay £100");
                        }
                        else
                        {
                            studentList[1] = (studentList[1]);
                            Console.WriteLine();
                            Console.WriteLine(studentList[1] + " has been enrolled and will need to pay £200");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("     *Press any key to return to main menu*");
                Console.WriteLine();
            }
            else if ((studentList[2]) == null)
            {
                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Please enter the name of the student you want to enroll");
                    Console.WriteLine();
                    newEnrollment = Console.ReadLine();
                    if (malfoyBool(newEnrollment))
                    {
                        Console.WriteLine();
                        Console.WriteLine("                   ****** ERROR ******                   ");
                        Console.WriteLine();
                        Console.WriteLine("Students with the last name Malfoy are not to be admitted");
                        Console.WriteLine();
                    }
                    else
                    {
                        studentList[2] = ((newEnrollment).ToLower());
                        if (PotterLastName(newEnrollment))
                        {
                            studentList[2] = (studentList[2]);
                            Console.WriteLine();
                            Console.WriteLine(studentList[2] + " has been enrolled and will need to pay £100");
                        }
                        else
                        {
                            studentList[2] = (studentList[2]);
                            Console.WriteLine();
                            Console.WriteLine(studentList[2] + " has been enrolled and will need to pay £200");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("     *Press any key to return to main menu*");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please choose an available option from the menu");
                Console.WriteLine();
                Console.WriteLine("     *Press any key to return to main menu*");
            }
            Console.WriteLine();
            //Console.WriteLine("     *Press any key to return to main menu*");
            Console.WriteLine();

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
            studentFeeList();
            for (int i = 0; i < studentList.Length; i++)
            {

                Console.WriteLine(i + 1 + ". "+ studentList[i]);
            }
            feesTotal();
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
                Console.ReadLine();
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
                Console.WriteLine("LIST OF CURRENT STUDENTS");
                Console.WriteLine();
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
        public static bool PotterLastName(string newEnrollment)
        {
            if ((newEnrollment.ToLower()).Contains(potter))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static string studentFee()
        {
            if (Fee())
            {
                return "(100)";
            }
            else
            {
                return "(200)";
            }
        }
        public static bool Fee()
        {
            if (newEnrollment.Contains(potter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        }
}
