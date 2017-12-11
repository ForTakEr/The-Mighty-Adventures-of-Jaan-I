using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsooliMäng
{
    class Program
    {
        static void Main(string[] args)
        {
            Statid statid = new Statid();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("The Mighty Adventures of Jaanus!");
            Console.WriteLine("Made by Moka Studio™ 2017\n");
            while (true)
            {
                Console.WriteLine("You are the mighty adventurer Jaanus");
                Console.WriteLine("Choose his class and title (same thing really)\n");
                Console.WriteLine("*Knight\n*Mage\n*Archer\n*Rogue");
                string klass = Console.ReadLine();

                if (klass == "Knight" || klass == "knight")
                {
                    statid.Knight();
                    Console.WriteLine("You are Jaanus the Knight");
                    break;
                }
                else if (klass == "Mage" || klass == "mage")
                {
                    statid.Mage();
                    Console.WriteLine("You are Jaanus the Mage");
                    break;
                }
                else if (klass == "Archer" || klass == "archer")
                {
                    statid.Archer();
                    Console.WriteLine("You are Jaanus the Archer");
                    break;
                }
                else if (klass == "Rogue" || klass == "rogue")
                {
                    statid.Rogue();
                    Console.WriteLine("You are Jaanus the Rogue");
                    break;
                }
                else
                {
                    Console.WriteLine("Not an option (the fuck)\n");
                }
            }
            Console.WriteLine("Töötab");
            Console.ReadLine();
        }
    }
}
