using System;
using System.Collections.Generic;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
        // SumandProduct();
        // SecondLargestNumber();
        // PrimeNoRemove();
        // duplicate();
        // repeat();
        // Sample();
        // Vowels();
        // Replace();
        // EvenOdd();
        // swap();
         cstring();
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
            List<int> mylist = new List<int>() { 1, 2, 30, 4, 5, 6, 7, 8, 9, 10 };
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
            List<int> numbers = new List<int>() { 2, 3, 6, 7, 12, 13, 15 };
            int a = 0;
            int p = 1;
            //int i = 0;
            int j;
          for (a = 0; a < numbers.Count; a++)

                {
                     for (j = 2; j < numbers[a]; j++)
                    {
                        if (numbers[a] % j == 0 && numbers[a] != 2)
                        {
                            p = 0;
                            break;
                        }
                    }
                    if (p == 1||numbers[a]==2)
                    {

                        numbers.RemoveAt(a);
                    a = a - 1;

                    }
                    p = 1;

                }
            for (int l = 0; l < numbers.Count; l++)
            {
                Console.Write(numbers[l]);
                Console.Write(" ");
            }
        }
        static void duplicate()
        {
            List<int> numbers = new List<int>() { 2, 2, 5, 8, 5, 9, 3 };
            int a = 0;
            int i = 0;
            for (a = 0; a < numbers.Count; a++)
            {
                for (i = a + 1; i < numbers.Count; i++)
                {
                    if (numbers[a] == numbers[i])
                    {
                        numbers.RemoveAt(i);
                    }
                }
            }
            for (int l = 0; l < numbers.Count; l++)
            {
                Console.Write(numbers[l]);
            }

        }
        static void repeat()
        {
            List<int> numbers = new List<int>() { 2, 2, 5, 8, 5, 9, 9, 8, 3 };
            int a = 0;
            int i = 0;
            for (a = 0; a < numbers.Count; a++)
            {
                for (i = a + 1; i < numbers.Count; i++)
                {
                    if (numbers[a] == numbers[i])
                    {
                        Console.Write(numbers[i]);
                    }
                }
            }
            Console.WriteLine(" ");
        }
        static void Sample()
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
            int l = 0;
            int p = 0;
            int n = 0;
            int s = 0;
            for (l = 0; l < numbers.Length; l++)
            {
                if (numbers[l] < 0)
                {
                    n = n + 1;
                }

                if (numbers[l] >= 0)
                {
                    p = p + 1;
                }
            }
            Console.WriteLine("The number of positive numbers:" + p);
            Console.WriteLine("The number of negative numbers:" + n);
            for (l = 0; l < numbers.Length; l++)
            {
                s = numbers[l] + s;
            }

            Console.WriteLine("The Sum:" + s);
            double avg = (double)s / N;
            Console.WriteLine("The Average:" + avg);
        }
        static void Vowels()
        {
            string word = "CUREMD";

            int i = 0;
            int v = 0;
            for (i = 0; i < word.Length; i++)
            {
                char d = word[i];
                char c = d;
                 if (c == 'A'|| c == 'E' || c == 'I' || c == 'O' || c == 'U'||c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                    v = v + 1;
                }
            }
            Console.WriteLine("Number of vowels are:" +v);
            
        }

        static void Replace()
        {
             double[] numbers = {5.8, 2.6,9.1,3.4,7};
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i - 1] +numbers[i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(" "+numbers[i]);
            }
        }

        static void EvenOdd()
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9, 13,14,18};
            List<int> newnum = new List<int>();
              for (int i = 1; i < numbers.Length; i++)
            {  
               if(numbers[i]%2==0)
                {
                    newnum.Add(numbers[i]);
                }
                              
            }


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    newnum.Add(numbers[i]);
                }

            }

            for (int p = 0; p < newnum.Count;p++)
            {
                Console.Write(" " + newnum[p]);
            }

        }

        static void swap()

        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 10, 7, 8, 9 };
            int i = 0;
            int a = numbers[i];
            numbers[i] = numbers[numbers.Length - 1];
            numbers[numbers.Length-1] = a;
            for (int p = 0; p < numbers.Length; p++)
            {
                Console.WriteLine(" " + numbers[p]);
            }

        }

        static void cstring()
        {
            String N;
            string newnum ="";
            //List<char> newnum = new List<char>();
            Console.Write("Enter String");
            N = Console.ReadLine();
            int i = 0;
            while (i < N.Length)
            {
                  if (N[i] == 'i' && N[i+1] == 'e' && N[i+2] == 's')
                {
                    newnum = newnum+'s';
                    i = i + 2;
                }
                else
                {
                    newnum = newnum + N[i];
                   
                }
                i = i + 1;
            }
            for (int p = 0; p < newnum.Length; p++)
            {
                Console.Write(newnum[p]);
            }
        }

       


}

    }
