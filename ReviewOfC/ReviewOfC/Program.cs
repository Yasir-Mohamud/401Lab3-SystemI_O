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
    }
}
