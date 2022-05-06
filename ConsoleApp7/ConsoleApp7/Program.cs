using System;
using System.IO;

namespace Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Challenge1();
           //Challenge2();
           // Challenge3();
         //  Challenge4();
            //Challenge5();
          // Challenge6();
          
           //Challenge8();
           // Challenge7();
            Challenge9();

        }


        public static void Challenge1()
        {

            Console.WriteLine("please enter 3 numbers seperated by space");
            string input = Console.ReadLine();
            Console.WriteLine($"The product of these 3 numbers is: {GetProduct(input)}");

        }
        public static int GetProduct(string input)
        {
            int output;
            int product = 1;
            string[] arr = input.Split(" ");
            if (arr.Length < 3)
                return 0;
            for (int i = 0; i < 3; i++)
            {

                output = Convert.ToInt32(arr[i]);
                product *= output;

            }

            return product;

        }

        public static decimal Challenge2()
        {
            Console.WriteLine("please enter a number between 2-10");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[input];
            int sum = 0;
            decimal average = 0;
            if (input < 2 || input > 10)
            {
                Console.WriteLine("Invalid Input!");
            }
            else
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"Please enter a number {i + 1} of {arr.Length} ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    sum += arr[i];
                }
                
                average = decimal.Divide(sum, arr.Length);
                Console.WriteLine($"The average of these numbers is: {(int)average}");
            }
            return average;
        }
        public static int GetAverage(int[] arr, int count)
        {
            int sum = 0;

            for (int i = 0; i < count; i++)
                sum += arr[i];

            return sum / count;
        }

        public static void Challenge3()
        {
            int size = 5;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");

                }
                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                Console.WriteLine();

            }
            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = size - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write("*");
                }
                for (int k = i - 1; k >= 1; k--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                Console.WriteLine();

            }


        }

        public static void Challenge4()
        {
            int[] arr = new int[] { 6, 7, 8, 9 };

            Console.WriteLine($"The most numbers duplicates is : {mostduplicates(arr)} ");


        }
        public static int mostduplicates(int[] a)
        {
            int count = 1, tempCount;
            int duplicate = a[0];
            int temp = 0;
            for (int i = 0; i < (a.Length - 1); i++)
            {
                temp = a[i];
                tempCount = 0;
                for (int j = 1; j < a.Length; j++)
                {
                    if (temp == a[j])
                        tempCount++;
                }
                if (tempCount > count)
                {
                    duplicate = temp;
                    count = tempCount;
                }
            }
            return duplicate;
        }

        public static void Challenge5()
        {
            int[] arr = new int[] { 120, 1, 90, 55, 140, 3, 135 };

            Console.WriteLine($"The max number in this array is : {GetMaximum(arr)}");

        }
        public static int GetMaximum(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }



        public static void Challenge6()
        {
            string path = "../../../words.txt";
           

            Console.Write("Enter your word: ");
            string input = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(path))
                sw.WriteLine(input);
        }

        public static void Challenge7()
        {
            string path = "../../../words.txt";

            Console.WriteLine("words.txt file contains the following words:");

            using (StreamReader sr = new StreamReader(path))
            {
                string word = "";
                while ((word = sr.ReadLine()) != null)
                    Console.WriteLine(word);
            }
        }
        public static void Challenge8()
        {
            string path = "../../../words.txt";

            Console.WriteLine("Please Enter a word to be deleted from 'Words.txt'");
            string input = Console.ReadLine();

            string[] fileContent = File.ReadAllLines(path);

            string[] words = fileContent[0].Split(" ");

            string newContent = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != input)
                    newContent += words[i] + " ";
            }

            File.WriteAllText("Words.txt", newContent);

            Console.WriteLine("The new content is");
            String[] newfileContent = File.ReadAllLines("Words.txt");
            for (int i = 0; i < newfileContent.Length; i++)
                Console.WriteLine(newfileContent[i]);
        }



        public static void Challenge9()
        {
            Console.WriteLine("Enter a sentence to be counted.");
            string input = Console.ReadLine();
            getword(input);
        }
        public static string[] getword(string input)
        {

            string[] arr = input.Split(" ");
            int output;
            for (int i = 0; i < arr.Length; i++)
            {
                output = arr[i].Length;

                arr[i] = $"\" {arr[i]} : {output} \", ";
                Console.Write(arr[i]);
            }
            return arr;
        }

    }
}
