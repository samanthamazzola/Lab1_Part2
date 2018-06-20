using System;

namespace GCPreworkLabPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string number1, number2, sum;
            char doAgain;
            bool repeat1 = true, repeat2 = true;

            while (repeat1 == true)
            {
                //string input
                Console.WriteLine("Please enter two numbers with the same amount of digits: ");
                Console.WriteLine("Please enter your first number: ");
                var number1 = Console.ReadLine();
                Console.WriteLine("Please enter your second number: ");
                var number2 = Console.ReadLine();

                //convert and assign an int value from string input 
                //OR int.Parse(number1); ????
                var num1 = Convert.ToInt16(Console.ReadLine());
                var num2 = Convert.ToInt16(Console.ReadLine());

                for (int i = 1, i < num1, i++)
                    if(num1[i] + num2[i] != num1[0] + num2[0])
                        return = false;
                {
                    Console.WriteLine("False");
                }
                else if(num1[i] + num2[i] != num1[0] + num2[0])
                    return = true;
                {
                    Console.WriteLine("True");
                }



                number1 = String.Concat(number1, "", number2);

                while (repeat2 == true)
                {
                    Console.WriteLine("Total of " + number1 + ", is your value.");
                    sum = Console.ReadLine();

                    if (sum == "yes" || sum == "Yes" || sum == "YES")
                    //parameters that will choose whether or not you move on to other statements
                    {
                        Console.WriteLine("Great news" + number1 " number.");
                        repeat2 = false; // if any are a yes variation it allows the program to move on
                    }
                    else if (sum == "no" || sum == "No" || sum == "NO")
                    {
                        Console.WriteLine("Sorry " + number1 + " .");
                        repeat2 = false;
                    }
                    else
                    //always returns true
                    {
                        Console.WriteLine("Sorry, please input a new number: ");

                    }
                }
                Console.WriteLine("Would you like to try this again? (Y or N)");
                doAgain = Convert.ToChar(Console.ReadLine());
                //since Read and Readline return string you need to convert 
                if(doAgain == 'y' || doAgain == 'Y')
                {
                    repeat1 = true;
                }
                else
                {
                    repeat1 = false; 
                }
            }
        }
    }
}