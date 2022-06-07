using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_fact_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your value");
           int value = int.Parse(Console.ReadLine());
           Console.WriteLine($"result : {fact(value)}");
            Console.ReadLine();
        }

        static int fact(int value)
  
        {
            if (value == 1) 
                return 1;
            if (value == 0)
                return 1;
            if (value < 0)
                return -1;
            return value * fact(value - 1);
        }
    }

    

}
