using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Reflection;

namespace lesson11
{
/*class MyMath
{
    public static T Divide<T>(T a, T b) where T: struct
    {
        switch (typeof(T).Name)
        {
            case "Int32":
                return (T) (object)((int)(object)a / (int)(object)b);
            case "Double":
                return (T)(object)((double)(object)a / (double)(object)b);
            default:
                return default(T);
        }
    }
}
class Program
{
    public static int Main()
    {
        Console.WriteLine(MyMath.Divide<double>(5.0, 2.0));
        return 0;
    }
}*/


class NumberToWords  
{  
    private static String[] units = { "Nol", "Bir", "Ikki", "Uch",  
    "To'rt", "Besh", "Olti", "Yetti", "Sakkiz", "To'qqiz", "O'n", "O'n bir",  
    "O'n ikki", "O'n uch", "O'n to'rt", "O'n besh", "O'n olti",  
    "O'n yetti", "O'n sakkiz", "O'n to'qqiz" };  
    private static String[] tens = { "", "", "Yigirma", "O'ttiz", "Qirq",  
    "Ellik", "Oltmish", "Yetmish", "Sakson", "To'qson" };  
  
    public static String ConvertAmount(double amount)  
    {  
        try  
        {  
            Int64 amount_int = (Int64)amount;  
            Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);  
            if (amount_dec == 0)  
            {  
                return Convert(amount_int);  
            }  
            else  
            {  
                return Convert(amount_int) + Convert(amount_dec);  
            }  
        }  
        catch (Exception e) {}  
        return "";  
    }  
  
    public static String Convert(Int64 i)  
    {  
        if (i < 20)  
        {  
            return units[i];  
        }  
        if (i < 100)  
        {  
            return tens[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : "");  
        }  
        if (i < 1000)  
        {  
            return units[i / 100] + " Yuz"  
                    + ((i % 100 > 0) ? " " + Convert(i % 100) : "");  
        } 
        if (i==1000){
            return "Ming";}
        if(i==100000){
            return "Yuz Ming";
        } 
        if (i < 1000000)  
        {           
            return Convert(i / 1000) + " Ming "  
             + ((i % 1000 > 0) ? " " + Convert(i % 1000) : "");  
        }
        if (i==100000000){
            return "Yuz Million";
        }  
        if (i < 1000000000)  
        {  
            return Convert(i / 1000000) + " Million "  
                    + ((i % 1000000 > 0) ? " " + Convert(i % 1000000) : "");  
        }  
        if (i==100000000000){
            return "Yuz Milliard";
        }
        if (i < 1000000000000)  
        {  
            return Convert(i / 1000000000) + " Milliard "  
                    + ((i % 1000000000 > 0) ? " " + Convert(i % 1000000000) : "");  
        }  
        return Convert(i / 1000000000000) + " Trillion "  
                + ((i % 1000000000000 > 0) ? " " + Convert(i % 1000000000000) : "");     
    }  

    static void Main(string[] args)  
{  
    try  
    {  
        Console.Write("Enter a number: ");  
        string number = Console.ReadLine();  
        number = ConvertAmount(double.Parse(number));  
        Console.WriteLine(number);  
        Console.ReadKey();  
    }  
    catch (Exception e)  
    {  
        Console.WriteLine(e.Message);  
    }  
   }
  }
}