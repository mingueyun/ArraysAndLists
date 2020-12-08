using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            ////// to make an array you have in instantiate an array. 

            ///// one way of instantiating an array
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[2] = 200;
            //numArray[4] = 5000;

            ///// easier way of making an array
            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000};

            ////// faster way of making an array
            //int[] numArray2 = {5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650; /// this changes parts of an array
            //Console.WriteLine(numArray[3]);
            //Console.WriteLine(numArray1[3]);
            //Console.WriteLine(numArray2[3]);
            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();

            ///---------------------------------------------list
            ///
            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);
            //Console.WriteLine(intList[0]);
            //Console.ReadLine();

            //List<string> intList = new List<string>();
            //intList.Add("Hello");
            //intList.Add("Jesse");
            //intList.Remove("Jesse");
            //Console.WriteLine(intList[0]);
            //Console.ReadLine();

            //byte[] byteArray = new byte[5000];/// for large quantity 


            string[] StringArray = { "jan", "feb", "mar", "apr", "may", "june", "jul", "aug", "sep", "oct", "nov", "dec" };
            Console.WriteLine("please select what month you were born in. 0 being jan - 11 being dec");
            int SelectString = Convert.ToInt32(Console.ReadLine());

            if (SelectString > -1 && SelectString < 12)
            {
                Console.WriteLine("The array contains the following values:");
                for (int i = StringArray.GetLowerBound(0); i <= StringArray.GetUpperBound(0); i++)
                    Console.WriteLine("   [{0,2}]: {1}", i, StringArray[i]);
                Console.WriteLine("you selected the month of " + StringArray[SelectString]);
            }
            else
            {
                Console.WriteLine("wrong selection choose another month");
            }



            int[] numArray = { 5, 10, 200, 100, 500, 1, 300, 600, 1000, 2, 555 };
            Console.WriteLine("please select from 0 - 10 for your lucky number ");
            int selectNumber = Convert.ToInt32(Console.ReadLine());

            if (selectNumber > -1 && selectNumber < 11)
            {
                Console.WriteLine("The array contains the following values:");
                for (int i = numArray.GetLowerBound(0); i <= numArray.GetUpperBound(0); i++)
                    Console.WriteLine("   [{0,2}]: {1}", i, numArray[i]);
                Console.WriteLine("Your lucky number is " + numArray[selectNumber]);
            }
            else
            {
                Console.WriteLine("Wrong selection choose another number");
            }


            List<string> pick = new List<string>(3) {"convertible","wheels", "engine"};

            Console.WriteLine("pick an number for your car needs. choose from 0-2");
            int choose = Convert.ToInt32(Console.ReadLine());

            if (choose > -1 && choose < 3)
            {
                Console.WriteLine("Content is an:  " + pick[choose]);
            }
            else
                Console.WriteLine(" uhh... what do you want from me? ");

            Console.ReadLine();

        }

    }
}
