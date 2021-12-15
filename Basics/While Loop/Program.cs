﻿using System;

namespace T05Coins_Ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());

            double temp = sum * 100;
            int cents = (int)temp;
            int numberOfCoins = 0;

            while (cents > 0)
            {
                if (cents >= 200)
                {
                    numberOfCoins += cents / 200;
                    cents %= 200;
                }
                else if (cents >= 100)
                {
                    numberOfCoins++;
                    cents %= 100;
                }
                else if (cents >= 50)
                {
                    numberOfCoins++;
                    cents %= 50;
                }
                else if (cents >= 20)
                {
                    numberOfCoins += cents / 20;
                    cents %= 20;

                }
                else if (cents >= 10)
                {
                    numberOfCoins++;
                    cents %= 10;
                }
                else if (cents >= 5)
                {
                    numberOfCoins++;
                    cents %= 5;
                }
                else if (cents >= 2)
                {
                    numberOfCoins += cents / 2;
                    cents %= 2;

                }
                else if (cents == 1)
                {

                    numberOfCoins++;
                    cents -= 1;
                }
            }


            Console.WriteLine(numberOfCoins);
        }
    }
}
