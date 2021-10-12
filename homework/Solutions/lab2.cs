using System;

namespace homework.Solutions
{
    class Lab2
    {
        public void Problem1()
        {
            System.Console.WriteLine("222222\n2    2\n2    2\n222222");
        }

        public void Problem2()
        {
            System.Console.WriteLine("  A\n A A\nAAAAA");
        }

        public void Problem3()
        {
            System.Console.WriteLine("Birthdate");
            System.Console.Write("Enter month: ");
            string month = Console.ReadLine();
            System.Console.Write("Enter date: ");
            string date = Console.ReadLine();
            int m1 = int.Parse(month);
            int d1 = int.Parse(date);
            string m = m1.ToString().PadLeft(2, '0');
            string d = d1.ToString().PadLeft(2, '0');
            System.Console.WriteLine("Birthday is " + m + '-' + d+" (mm-dd).");            
        }

        public void Problem4()
        {
            System.Console.WriteLine("Birthdate");     System.Console.Write("Enter Month and Date: ");
            string month = Console.ReadLine();    string date = Console.ReadLine();
            int m1 = int.Parse(month);    int d1 = int.Parse(date);
            string m = m1.ToString().PadLeft(2, '0');     string d = d1.ToString().PadLeft(2, '0');
            System.Console.WriteLine("Birthday is " + m + "-" + d+" (mm-dd).");
        }
        
        public void Problem5()
        {
        Console.Write("Enter integer: ");
        string n = Console.ReadLine();
        System.Console.WriteLine(n+n+n+n+n+n+"\n"+n+"    "+n+"\n"+n+"    "+n+"\n"+n+n+n+n+n+n);
        }

        public void Problem6()
        {
            System.Console.Write("Enter integer: ");
            string number = Console.ReadLine();
            int n = int.Parse(number);
            for(int i = 1; i <= 9; i++)
            {
                System.Console.WriteLine(n + "*" + i + '=' + n * i);
            }
        }

        public void Problem7()
        {
            for(int i = 1; i <= 5; i++)
            {
                string t = i.ToString();
                System.Console.Write(t + '!' + '=');
                int f = 1;
                for(int j = 1; j <= i; j++)  {  f *= j; }
                string result = f.ToString();
                System.Console.WriteLine(result);
            }
        }

        public void Problem8()
        {
            int f1 = 0, f2 = 1, fibonacci = f1 + f2;
            System.Console.WriteLine("1");
            System.Console.WriteLine(f2);
            for(int i = 0; i < 4; i++)
            {
                f1 = f2;  f2 = fibonacci;  fibonacci = f1 + f2;
                System.Console.WriteLine(fibonacci);
            }
        }
    }
}