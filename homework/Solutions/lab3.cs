using System;

namespace homework.Solutions
{
    class Lab3
    {
        public void Problem1()
        {
            
        }

        public void Problem2()
        {
            System.Console.Write("Width: ");
            string s1 = Console.ReadLine();
            System.Console.Write("Length: ");
            string s2 = Console.ReadLine();
            System.Console.Write("Area->");
            float a = float.Parse(s1);
            float b = float.Parse(s2);
            System.Console.WriteLine(a * b);
        }  

        public void Problem3()
        {
            Console.Write("Input (Real number): ");
            string s = Console.ReadLine();
            double n = double.Parse(s);
            int n1 = (int)Math.Round(n, MidpointRounding.AwayFromZero);
            Console.WriteLine("Round off (Integer)->" + n1);  
        }

        public void Problem4()
        {
            System.Console.Write("Input (lower case): ");
            string s = Console.ReadLine();
            char ch = char.Parse(s);
            System.Console.WriteLine("Output upper case->"+(char)(ch - 32));
        }

        public void Problem5()
        {
            System.Console.Write("Input (upper case): ");
            string s = Console.ReadLine();
            char ch = char.Parse(s);
            System.Console.WriteLine("Output (lower case)->"+(char)(ch + 32));
        }
    }
}