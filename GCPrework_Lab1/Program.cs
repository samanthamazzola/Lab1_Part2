using System;

namespace GCPrework_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSum1, numSum2;
            Console.WriteLine("\n\n");
            Console.WriteLine("Add each integer of two different numbers. Are the values the same?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Type a number with 3 integers:");
            numSum1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Type a different number with 3 integers:");
            numSum2 = Convert.ToInt16(Console.ReadLine());

            if (numSum1 == numSum2)
                Console.WriteLine("{0} and {1} are equal.\n", numSum1, numSum2);
            else 
                Console.WriteLine("{0} and {1} are NOT equal.\n", numSum1, numSum2);
        }
    }
}







            /*int number1 = 1;
            if (number1 == 1) ;
            Console.WriteLine(number1);

            int number1, number2, numberSum;
            char doAgain;
            bool decision1 = true; decision2 = true;

            Console.WriteLine("Please enter a value in hundreds.");
            number1 = Console.ReadLine();

            Console.WriteLine("Please enter another number in hundreds");
            number2 = Console.ReadLine();



            if(numberSum == "yes" || numberSum == "Yes" || numberSum == "YES")
            {
                Console.WriteLine(""
            }






            int number1, number2, solution = 1, total;
            char doAgain;
            bool decision = true;

            while (decision == true)
            {
                solution = 1;
                Console.WriteLine("Please enter a number with three digits");
                number1 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Please enter another number with three digits");
                number2 = Convert.ToInt16(Console.ReadLine());

                total

                for (int temp = number1; temp > total; temp --)
                {
                    solution *= temp;
                }
            }*/
