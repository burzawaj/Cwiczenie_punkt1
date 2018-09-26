using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie_punkt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt nowyPunkt = new Punkt(0, 0);

            Console.WriteLine("Współrzędna X: {0}", nowyPunkt.WSPX);
            Console.WriteLine("Współrzędna Y: {0}", nowyPunkt.WSPY);

            Punkt nowyPunkt2 = new Punkt(1, 1);
            Console.WriteLine("Współrzędna X1: {0}", nowyPunkt2.WSPX);
            Console.WriteLine("Współrzędna Y1: {0}", nowyPunkt2.WSPY);
            
            


            /*nowyPunkt.PrzesunWGore(5);
            Console.WriteLine("Współrzędna X: {0}", nowyPunkt.WSPX);
            Console.WriteLine("Współrzędna Y: {0}", nowyPunkt.WSPY);
            nowyPunkt.PrzesunWDol(11);
            Console.WriteLine("Współrzędna X: {0}", nowyPunkt.WSPX);
            Console.WriteLine("Współrzędna Y: {0}", nowyPunkt.WSPY);
            nowyPunkt.PrzesunWLewo(8);
            Console.WriteLine("Współrzędna X: {0}", nowyPunkt.WSPX);
            Console.WriteLine("Współrzędna Y: {0}", nowyPunkt.WSPY);
            nowyPunkt.PrzesunWPrawo(12);
            Console.WriteLine("Współrzędna X: {0}", nowyPunkt.WSPX);
            Console.WriteLine("Współrzędna Y: {0}", nowyPunkt.WSPY);
            */
            Console.ReadKey();
        }
    }
}
