﻿using System;
using System.Collections.Generic;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // SumandProduct();
            //  SecondLargestNumber();
            PrimeNoRemove();

            }




        static void SumandProduct()
        {
            int N;
            Console.Write("Enter size of array");
            N = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[N];
            int i;
            Console.WriteLine("Enter elements of array");
            for (i = 0; i < N; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Entered elements of array are: ");
            for (i = 0; i < N; i++)
            {
                Console.Write(numbers[i]);
            }

            int sum = 0;

            for (i = 0; i < N; i++)
            {
                sum = sum + numbers[i];

            }

            Console.WriteLine("\nSum of all numbers in an array is: " + sum);

            int product = 1;

            for (i = 0; i < N; i++)
            {
                product = product * numbers[i];

            }

            Console.WriteLine("Product of all numbers in an array is: " + product);
        }

            static void SecondLargestNumber()
            {
                List <int> mylist = new List <int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int biggest = mylist[0];
                for (int i = 1; i < mylist.Count; ++i)
                {
                    if (mylist[i] > biggest)
                    {
                        biggest = mylist[i];
                    }
                }
            Console.WriteLine("Largest number of array is " + biggest);
            mylist.Remove(biggest);

            int sebig = mylist[0];
            for (int i = 1; i < mylist.Count; ++i)
            {
                if (mylist[i] > sebig)
                {
                    sebig = mylist[i];
                }
            }
            Console.WriteLine("Second Largest number of array is " + sebig);
                      
            }

        static void PrimeNoRemove()
        {
            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int a = 0;

            int i = numbers[a];
            int j;
            for (j = 2; j < i; j++)
            {
                if (i % j == 0)
                    Console.WriteLine("Entered Number is not prime");
                else
                    Console.WriteLine("Entered Number is prime");
                j = i;
            }
        }

    }
    }


