using IlmhubProblems.Solutions.LittlePrince;

namespace IlmhubProblems
{
    class Program
    {

         //Little Prince
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            while(t-->0)
            {
                System.Console.WriteLine(new Prince().Travel());
            }
        } 


        
    }
}