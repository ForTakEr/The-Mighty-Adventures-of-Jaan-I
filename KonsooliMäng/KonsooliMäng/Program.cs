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
                    Console.WriteLine("Not an option (...the fuck?)\n");
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("You wake up in a strange forest, everything around you is dark and creepy... you hear thunder in the distance. You clutch your weapon in fear. It's frightening, what do you do?\n1. Look around\n2. Take a rest");
                string response = Console.ReadLine();
                if (response == "1")
                {
                    break;
                }
                else if (response == "2")
                {
                    Console.WriteLine("You have more important things to do than jack off to an extra curvy piece of driftwood that’s shaped like your old neighbours goat");
                }
                else
                {
                    Console.WriteLine("Please choose one of the options");
                }
            }
            string path;
            while (true)
            {
                Console.WriteLine("You notice 3 pathways in the distance, you go closer and notice an old ghost-man is in front of one of the paths, he proclaims: “One of these paths will bring you good fortune, the others only hardship CHOOSE WISELY FOR IT CANNOT BE CHANGED LATER!”\n1. Ask him for advice\n2. Choose the left path\n3. Choose the middle path\n4. Choose the right path\n");
                path = Console.ReadLine();
                if (path == "1")
                {
                    Console.WriteLine("“I won't tell you squat” he says");
                    Console.WriteLine();
                }
                else if (path == "2")
                {
                    Console.WriteLine("You choose the left path");
                    break;
                }
                else if (path == "3")
                {
                    Console.WriteLine("You choose the middle path");
                    break;
                }
                else if (path == "4")
                {
                    Console.WriteLine("You choose the right path");
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose one of the options");
                }
            }
            if (path == "2") //SEE ON GERDI OMA
            {

            }
            else if (path == "3") //SEE ON SIMO OMA
            {

            }
            else if (path == "4") //SEE ON KERDI OMA
            {

            }
            Console.ReadLine();
        }
    }
}
