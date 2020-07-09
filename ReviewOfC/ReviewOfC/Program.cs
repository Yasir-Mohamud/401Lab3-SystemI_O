using System;

namespace ReviewOfC
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }


        /// <summary>
        /// Calls the product string method and shows on console
        /// </summary>

         static void HandlesProductString ()
        {
            Console.WriteLine("Enter 3 numbers seperated by a space ie 1 2 3");
            string userInput = Console.ReadLine();
            int result = ProductString(userInput);
            Console.WriteLine($"The product of these 3 numbers is:{result} ");
        }

        /// <summary>
        /// gets a string as input and finds the product of the first 3 in the array.
        /// </summary>
        /// <param name="userInput"> a string inputted by a user </param>
        /// <returns> product of first 3 numbers entered  </returns>

        public static int ProductString(string userInput)
        {
            string[] arr = userInput.Split(' ');
            if (arr.Length < 3)
            {
                return 0;
            }
            int product = 1;
            for (int i = 0; i < 3; i++)
            {
                product *= int.TryParse(arr[i], out int returnVal) ? returnVal : 1;
            }
            return product;
        }



        //// challenge2

        /// <summary>
        /// Gets input from user and calls the GetsAvrage method
        /// </summary>
        static void HandlesAverage()
        {
            Console.WriteLine("Please enter a number between 2-10:");
            int userInput = int.Parse(Console.ReadLine());
            string[] arr = new string[userInput];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} of {arr.Length} - Enter a number: ");
                // sets the input from the console into the array
                arr[i] = Console.ReadLine();

            }

            int[] number = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                
                number[i] = int.Parse(arr[i]);
               
            }

            decimal result = GetsAverage(number);
            Console.WriteLine($"The average of {arr.Length} is {result}");
        }

        /// <summary>
        /// Gets an array of integers and finds the average
        /// </summary>
        /// <param name="arr"> input of array of integers</param>
        /// <returns>average of integers</returns>
        public static decimal GetsAverage(int[] arr)
        {
            decimal result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result / arr.Length;
        }
    }
}
