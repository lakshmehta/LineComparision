using System;

namespace LineComUC4
{
    class Program
    {
        static double x1;
        static double y1;
        static double x2;
        static double y2;
        static double a1;
        static double b1;
        static double a2;
        static double b2;

        static String value;
        public static void Main()
        {
            Console.WriteLine("Enter X and Y Co-ordinates values for 1st Line");
            value = Console.ReadLine();
            x1 = double.Parse(value);
            value = Console.ReadLine();
            y1 = double.Parse(value);
            value = Console.ReadLine();
            x2 = double.Parse(value);
            value = Console.ReadLine();
            y2 = double.Parse(value);
            Console.WriteLine("Enter X and Y Co-ordinates values for 2nd Line");
            value = Console.ReadLine();
            a1 = double.Parse(value);
            value = Console.ReadLine();
            b1 = double.Parse(value);
            value = Console.ReadLine();
            a2 = double.Parse(value);
            value = Console.ReadLine();
            b2 = double.Parse(value);
            double line1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double line2 = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2));
            Console.WriteLine("Length of 1st Line: " + line1 + " and Length of 2nd Line " + line2);
            if (line1 == line2)
                Console.WriteLine("Both lines are Equal");
            else if (line1.CompareTo(line2) > 0)
                Console.WriteLine("Line1  is greater than Line2");
            else if (line1.CompareTo(line2) == 0)
                Console.WriteLine("Line1 is equal to Line2");
            else
                Console.WriteLine("Both Lines are Equal");


        }
    }
}
