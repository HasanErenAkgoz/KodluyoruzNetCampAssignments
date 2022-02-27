using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            solve(12,20,8);

        }
        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
          
           double totalcost=meal_cost+tip_percent+tax_percent;
           System.Console.WriteLine(Math.Round(totalcost));

           
            
        }
    }
}
