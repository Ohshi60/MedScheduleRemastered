using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedScheduleRemastered
{
    class Program
    {
        static void Main(string[] args)
        {
            Plan p = new Plan(5);
            //p.Printplan();
            Plan p2 = p.SuperPlan(1000000,30);
            p2.Printplan();
            Console.ReadKey();

        }
    }
}
