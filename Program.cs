﻿using System.Net.Mime;
using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Using Arrays - Exercise One");

            // string[] mynames = new string[5];

            // mynames[0] = "Qui";
            // mynames[1] = "Tame Impala";
            // mynames[2] = "Baby Bash";
            // mynames[3] = "The Neighbourhood";
            // mynames[4] = "Cold Play";

            // foreach(string name in mynames)
            // Console.WriteLine("Hello" + name);
         
            // Console.WriteLine("=======================================");
            // Console.WriteLine("Using Arrays - Exercise Two");

            // int[] numbers = new int[10] {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};

            // int sum = 0; 

            // Array.ForEach(numbers, i => sum += i);
            // Console.WriteLine(sum);


            // Console.WriteLine("=======================================");
            // Console.WriteLine("Using Lists - Exercise One");
            
            // List<int> mynum = new List<int>();
           
            // Console.WriteLine("Insert 5 numbers!");
                // for (int i = 1; i <= 5; i++) {
                // mynum.Add(int.Parse(Console.ReadLine()));

            // Console.WriteLine("Insert another number!");
            // int anotherNum = int.Parse(Console.ReadLine());
            //    if (mynum.Contains(anotherNum)) {
            //        Console.WriteLine("This number has already been entered!");
            //    }
            //    else {
            //        Console.WriteLine("This number has not been added!");
            //    }

            Console.WriteLine("=======================================");
            Console.WriteLine("Using Lists - Exercise Two");

            List<int> myNumbers = new List<int>();
			HashSet<int> uniqueNumbers = new HashSet<int>();
            Dictionary<int, int> numberDict = new Dictionary<int, int>();

			Console.WriteLine("Please enter five numbers");
			for (int i = 1; i <= 5; i++)
			{
				int number = int.Parse(Console.ReadLine());
				myNumbers.Add(number);
				uniqueNumbers.Add(number);
			}

            Console.WriteLine("Numbers");
            foreach (int num in myNumbers)
            {
                if (uniqueNumbers.Contains(num))
                {
                    if (!numberDict.ContainsKey(num))
                    {
                        numberDict.Add(num, 1);
                    }
                    else
                    {
                        numberDict[num] = numberDict[num] + 1;
                    }
                }
            }

            foreach(KeyValuePair<int, int> kvp in numberDict)
            {
                Console.WriteLine("{0} repeats {1} times", kvp.Key, kvp.Value);
            

            Console.WriteLine("=======================================");
            Console.WriteLine("Using Lists - Exercise Three");

        }
    }
}
