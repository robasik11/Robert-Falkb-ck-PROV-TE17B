using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Böcker
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        public int a;
        public int r;
        private bool cursed;

        //Här har jag gjort strings och ints och deras namn

        public void Book()
        {
            name = Console.ReadLine();
            Random generator = new Random();
            actualValue = generator.Next(0, 101);
            rarity = generator.Next(0, 101);
            price = generator.Next(0, 101);

            //här är min metod book som genererar slumpmässiga tal till värden, rarity och pris!

        }
        private bool isCursed()
        {
            a = actualValue;
            r = rarity;
            //här försökte jag göra en bool till min cursed med en egen metod jag hittade på, jag ansåg att om man har tur och lyckas få till att ens slumpmässiga 
            //bok har value och rarity över 80 så kommer boken bli cursed så det blir lite mer balanserat vid en bra bok



            if (actualValue >= 80 && rarity >= 80)
            {

                return true;
            }

            while (true)

            {
                Console.WriteLine("Denna bok har en förbannelse, vill du ha den?");
                string cursed = Console.ReadLine();
                if (cursed == "ja")
                {
                    Console.WriteLine("Lycka till!!");
                    return true;
                }
                else if (cursed == "nej")
                    return false;
                //här kan man välja om man vill ha boken eller inte med en liten while loop
            }



        }

        public void getCategory()
        {
            //här försökte jag göra en array som har 3 olika kategorier i sig där man kan få slumpat om en bok är historia, drama eller spännning
            int[] category = new int[3];
            string[] choices = { "Historia", "Drama", "Spänning" };


        }

        public void printInfo()
        {
            //print info är den lättaste metoden här då den endast skriver ut alla slumpgenererade värden pch gett de olika variablerna.
            Console.WriteLine("Boken heter: " + name);
            Console.WriteLine("Boken har en sällsynthet på " + rarity + " av 100");
            Console.WriteLine(category);
            Console.WriteLine("boken kostar " + price + " Guldmynt");
        }


        public void Evaluate(int value)
        {
            //(actualValue * rarity == Evaluate)

            //här han jag inte med att göra en fungerande Evaluate metod som skulle räkna ut värdet


        }

        public void getName()
        {

            Console.WriteLine(name);
        }

    }
}
