using System;

namespace LabPart2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nEnter date1 below.");
            DateTime date1 = getDate();
            Console.WriteLine("\nEnter date2 below.");
            DateTime date2 = getDate();

            TimeSpan interval = date2 - date1;
            double days = interval.Days;
            double hours = days * 12;
            double minutes = hours * 60;

            Console.WriteLine("   {0,-15} {1,10}", "Total Number of Days:", days);
            Console.WriteLine("   {0,-15} {1,10}", "Total Number of Hours:", hours);
            Console.WriteLine("   {0,-15} {1,10}", "Total Number of Minutes:", minutes);

            Console.WriteLine("Hit any key to continue...");
            Console.ReadKey();
        }

        public static DateTime getDate()
        {
            Console.Write("Enter year: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.Write("Enter day: ");
            int day = Int32.Parse(Console.ReadLine());

            return new DateTime(year, month, day);
        }
    }
}
