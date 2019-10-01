using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Program
    {
        static void Main(string[] args)
        {
            Böcker b = new Böcker();
            Kunder k = new Kunder();
            Console.WriteLine("Hej och välkommen till vårt antikvariat! Här har vi böcker!\nVad heter boken du vill lämna/köpa?");
            //här skriver jag bara ut början av storryn och efter det har jag en print info där den skriver ut allt. 
            b.Book();
            Console.Clear();

            

            //skulle vela ha mer tid så jag kan slutföra projektet! rolig uppgift! /Robert 

            b.printInfo();

            Console.ReadKey();
        }
    }
}
