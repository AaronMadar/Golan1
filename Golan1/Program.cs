using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Golan1
{
    internal class Program
    {
        static List<int> numberList = new List<int>();

        static bool run = true;

        static bool run2 = true;

        static void Main(string[] args)
        {


            WelcomeAndCollect();






        }

        static void WelcomeAndCollect()
        {

            while (run)
            {
                TitleWelcome();
                string entry = Console.ReadLine().ToUpper();

                VerifyAndCollect(entry);

            }


        }


        static void TitleWelcome()
        {
            if (numberList.Count == 0)
            {
                Console.WriteLine("Please enter 3 positif numbers : " + " " + ExitOption());
            }

            else if (numberList.Count == 1)
            {
                Console.WriteLine("Please enter 2 positif numbers: " + " " + ExitOption());

            }

            else if (numberList.Count == 2)
            {
                Console.WriteLine("Please enter 1 positif number: " + " " + ExitOption());

            }

            else if (numberList.Count >= 3)
            {

                Console.WriteLine("Enter another number: " + " " + ExitOption());
                Console.WriteLine("For the MENU press M ");

            }



        }

        static string ExitOption()
        {
            return "Press X to Exit ";
        }





        static void VerifyAndCollect(string entry)
        {
            if (entry == "X")
            {
                Console.WriteLine("GoodBye !");
                run = false;
            }

            else if (entry == "M" && numberList.Count >= 3)
            {
                TheCalculMenu();
                run = false;
            }

            else if (!int.TryParse(entry, out int value) || value <= 0)
            {
                Console.WriteLine("Just Positive Numbers are Allowed !");

            }

            else
            {
                numberList.Add((int)value);
            }




        }


        static void TheCalculMenu()
        {
            Console.WriteLine("To see the list PRESS A");
            Console.WriteLine("To see the list reversed PRESS B");
            Console.WriteLine("To see the list sorted PRESS C");
            Console.WriteLine("To see the biggest number PRESS D");
            Console.WriteLine("To see the little number PRESS E");
            Console.WriteLine("To see the Average PRESS F");
            Console.WriteLine("To see the length PRESS G");
            Console.WriteLine("To see the sum PRESS H");
            Console.WriteLine("To enter a new list PRESS L");

            EntryMenu();
        }

        static void EntryMenu()
        {

            while (run2)
            {


                string entryMenu = Console.ReadLine().ToUpper();

                switch (entryMenu)
                {
                    case "A":
                        PrintList();
                        break;


                    case "B":
                        PrintListReversed();
                        break;



                    case "C":
                        PrintListSorted();
                        break;


                    case "D":
                        PrintTheBiggestNumber();
                        break;




                    case "E":
                        PrintLittleNumber();

                        break;


                    case "F":
                        PrintTheAverage();
                        break;



                    case "G":
                        PrintTheLength();
                        break;


                    case "H":
                        PrintTheSum();
                        break;


                    case "L":
                        ClearList();
                        break;



                    case "X":
                        Console.WriteLine("GoodBye! ");
                        run2 = false;
                        break;


                    default:
                        Console.WriteLine("Please press a valid option!");


                        break;












                }
            }

        }



        static void PrintList()
        {

            Console.WriteLine("The numbers in the list are " + string.Join(",", numberList));

        }

        static void PrintListReversed()
        {
            var reversed = new List<int>(numberList);
            reversed.Reverse();
            Console.WriteLine("The List Reversed is :" + string.Join(",", reversed));
        }



        static void PrintListSorted()
        {
            var sorted = new List<int>(numberList);
            sorted.Sort();
            Console.WriteLine("The list Sorted is : " + string.Join(",", sorted));
        }

        static void PrintTheBiggestNumber()
        {
            Console.WriteLine("The biggest number is : " + numberList.Max());
        }

        static void PrintLittleNumber()
        {
            Console.WriteLine("The little number is : " + numberList.Min());
        }

        static void PrintTheAverage()
        {

            int sumi = 0;
            foreach (int n in numberList)
            {
                sumi += n;
            }
            Console.WriteLine("The average is : " + (sumi / numberList.Count));
        }

        static void PrintTheLength()
        {
            Console.WriteLine("The length of the list is : " + numberList.Count);
        }

        static void PrintTheSum()
        {
            Console.WriteLine("The sum of all numbers of the list is : " + numberList.Sum());
        }

        static void ClearList()
        {
            numberList.Clear();
            WelcomeAndCollect();
        }


    }
}











        
