using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Web;
namespace _6december.Models
{
    public class Solve
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }

    public void Calculate()
    {
        double inside = (b*b) - 4*a*c;
        if (inside < 0)
        {
            x1 = double.NaN;
            x2 = double.NaN;
        }
        else
        {
            double equation = Math.Sqrt(inside);
            x1 = (-b + equation)/(2*a);
            x2 = (-b - equation)/(2*a);
        }
    }
    
}
}