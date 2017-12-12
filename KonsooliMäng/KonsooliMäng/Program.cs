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
                
                Console.WriteLine("--------------------------------------------------------------------------------------------------");
                Console.WriteLine("\nYou embark on your journey, you start walking towards your path. \nTime passes \n\nYour mind wanders if this was the right choice, your heart stays true \nbut your mind questions. \n“Thou ought thunk he chosen the rightest of paths, ought to be'ist thar complicatest“ \nYou begin to see green leaves and green trees, night starts to overwhelm the sky. \nYou feel tired. You are thinking of making a camp");
                Console.WriteLine("\nAre You going to find a campsite or going to get firewood. \n1.Get wood, then find camp \n2.Find campsite, then firewood");
                while (true)
                {
                    while (true)
                    {
                        string valik = Console.ReadLine();
                        if (valik == "1")
                        {
                            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\nYou search the forest, to find some wood. \nYou found yourself some firewood. \nYou start to look for a campsite, you found it. It isn’t perfect, but it will do.");
                            break;
                        }
                        else if (valik == "2")
                        {
                            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\nYou search the forest for a campsite. \nYou found a nice place near a river. \nYou put your belongings on the ground and go to find firewood. \n\nYou found some firewood, but not much.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Choose the right number");

                        }
                    }

                    while (true)

                    {
                        Console.WriteLine("\nYou're sitting by the fire, you hear cracking sounds in the bushes. what do you do? \n1. Investigate \n2. Ignore.");
                        string valik2 = Console.ReadLine();
                        if (valik2 == "1")
                        {
                            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\nYou grab your weapon, hold it tight and ready to fight. You walk to the bushes, open them and slash whatever is inside. \nThere was nothing there. \nYou think of yourself as such a fool, walk back and hear it again.. This time you ignore it. \nYou Hear a klonk, your head aches, \nyou fall down. \neverything fades..");
                            break;
                        }

                        else if (valik2 == "2")
                        {
                            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\nYou ignore it, \nUnexpectedly you Hear a klonk, your head aches. \nYou fall down. \neverything fades..");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Choose the right number");
                        }
                    }
                    
                    while (true)
                    {
                        Console.WriteLine("\n\nYou are unconcious.. \n1.Try to wake up.");
                        string valik3 = Console.ReadLine();
                        if (valik3 == "1")
                        {
                            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\nYou opened your eyes.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Choose the only option");
                        }
                                               
                    }
                    while (true)
                    {
                        Console.WriteLine("You hear some keys rambling in the distance. \n1.Try to move. \n2.Try Not to move.");
                        string valik4 = Console.ReadLine();
                        if (valik4 == "2")
                        {
                            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\nYou stayed still, you hear someone walking towards you.");
                            break;
                        }
                        else if (valik4 == "1")
                        {
                            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\nYou tried to move, but you are tired. You hear someone walking towards you.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Choose something");
                        }
                    }
                    Console.WriteLine("He lits up a torch, looks for his keys and opens your cell. \nNext thing he does is he puts your food in the corner. You see an oppurtunity to grab his knife and kill him. \nWhat do you do? \n1. Try to grab his knife \n2. Try not to make a sound");
                    while (true)
                    {
                        string valik5 = Console.ReadLine();
                        if (valik5 == "1")
                        {
                            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\nYou grabbed his knife, he noticed. What do you do? \n1. Stab him. \n2.Threaten him.");
                            break;
                        }
                        if (valik5 == "2")
                        {
                            Console.WriteLine("\n--------------------------------------------------------------------------------------------------\nYou stayed still");
                            string valik7 = Console.ReadLine();
                            while (true)
                            {
                                Console.WriteLine("He walks up to you, he notices you have moved. \nHe grabs his knife, What do you do? \n1. Try to block him from trying to stab you");
                                if (valik7 == "1")
                                {
                                    Console.WriteLine("You failed to block him. \nYOU DIED");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("choose again");
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("choose something");
                        }                        
                    }
                    string valik6 = Console.ReadLine();
                    while (valik6 == "1")
                    {
                        if (valik6 == "1")
                        {
                            Console.WriteLine("You stabbed him");
                            break;
                        }
                        if (valik6 == "2")
                        {
                            Console.WriteLine("You threatened him.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("choose again");
                        }
                    }
                    Console.WriteLine("The masters are pleased");
                    
                }
            }
            Console.ReadLine();
        }
    }
}

