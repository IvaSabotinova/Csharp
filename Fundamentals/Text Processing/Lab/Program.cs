﻿using System;




namespace T01ReverseStringsVer3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string reversedInput = string.Empty;

                for (int i = input.Length-1; i >=0 ; i--)
                {
                    reversedInput += input[i];

                }

                Console.WriteLine($"{input} = {reversedInput}");


                input = Console.ReadLine();
            }


        }

    }
}
