using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        

        

        public static int[] Mult3Bad(int[] anArray)
        {
            for (int i = 0; i < 49; i++)
            {
                if (anArray[i] % 3 == 0)
                {
                    anArray[i] = 0;
                }
            }
            return anArray;
        }

        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays


            string name = "chaz";
            name.ToUpper();
            Console.WriteLine(name);

            // Create an integer Array of size 50
            int[] bigArray = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(bigArray);

            //Print the first number of the array

            Console.WriteLine(bigArray[0]);

            //Print the last number of the array

            Console.WriteLine(bigArray[49]);


            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            
            Console.WriteLine("-------------------");
            NumberPrinter(bigArray);

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            //     Hint: Array._____(); Create a custom method     



            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(bigArray);
            NumberPrinter(bigArray);



            Console.WriteLine("---------REVERSE CUSTOM------------");

            

            NumberPrinter(ReverseArray(bigArray));

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");


            NumberPrinter(ThreeKiller(bigArray));

            Console.WriteLine("-------------------");

            //Sort the array in order now
            //      Hint: Array.____()      
            Console.WriteLine("Sorted numbers:");
            Array.Sort(bigArray);

            NumberPrinter(bigArray);

            Console.WriteLine("\n************End Arrays*************** \n");
           
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var bigList = new List<int>();

            //Print the capacity of the list to the console

            Console.WriteLine(bigList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(bigList);

            //Print the new capacity

            Console.WriteLine(bigList.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            int answer;
            string p;
            int count = 0;
            do
            {
                if (count == 0)
                {
                    Console.WriteLine("tell me your guess");
                }else
                {
                    Console.WriteLine("Ok dumb dumb a number is like how many times you've cried in the shower.");
                }
                p = Console.ReadLine();
                count++;

            }
            while (int.TryParse(p, out answer) == false);

            NumberChecker(bigList, answer);



            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(bigList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");

            OddKiller(bigList);

            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");

            bigList.Sort();
            NumberPrinter(bigList);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable

            int[] listToArray = bigList.ToArray();

            //Clear the list

            NumberPrinter(listToArray);
            bigList.Clear();
           
            #endregion
        }

        private static int[] ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < 49; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            return numbers;
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count - 1; i > -1; i--)
            {
                if (numberList[i] % 2 == 1)
                {
                    numberList.RemoveAt(i);
                }//can also use a for each loop and it's much easier. 
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            Console.WriteLine(numberList.Contains(searchNumber));
        }

        private static List<int> Populater(List<int> bigList)
        {
            for (int i = 0; i < 50; i++)
            {

                var r = new Random();
                bigList.Add(r.Next(0, 50));

            }
            return bigList;

        }

        private static int[] Populater(int[] numbers)
        {
            for (int i = 0; i < 50; i++)
            {
                var r = new Random();
                numbers[i] = r.Next(0, 50);
            }
            return numbers;
        }        

        private static int[] ReverseArray(int[] array)
        {
            for (int i = 0; i < 24; i++)
            {
                int temp = 0;
                int temp2 = 0;
                temp = array[i];
                temp2 = array[49 - i];
                array[i] = temp2;
                array[49 - i] = temp;

            }
            return array;
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
