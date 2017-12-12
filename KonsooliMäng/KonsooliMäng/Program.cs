using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KonsooliMäng
{
    class Program
    {
        static void Main(string[] args)
        {
            Statid statid = new Statid();
            Koletised koletised = new Koletised();
            CombatSystem combat = new CombatSystem();
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
                    Console.WriteLine("You choose the left path\n");
                    break;
                }
                else if (path == "3")
                {
                    Console.WriteLine("You choose the middle path\n");
                    break;
                }
                else if (path == "4")
                {
                    Console.WriteLine("You choose the right path\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose one of the options");
                }
            }
            if (path == "2") //SEE ON GERDI OMA
            {
                Console.WriteLine("You are attacked by a troll in the forest!");
                Random randomNumber = new Random();
                combat.Fight("Mob1");
                Console.WriteLine("On ok? " + koletised.HP);
                Console.WriteLine("What do you do?\n1. Attack the enemy\n2. Flee\n3. Block");
                string vastus = Console.ReadLine();

                if (vastus == "1")
                {
                    //Mob tuleb välja kutsuda muidu ei tööta
                    koletised.Mob1();
                    var damage = randomNumber.Next(statid.ATK - 6, statid.ATK + 2);
                    koletised.HP = koletised.HP - damage;
                    Console.WriteLine(koletised.HP);
                }
                

            }
            else if (path == "3") //SEE ON SIMO OMA
            {
                Console.WriteLine("As you start walking down the middle path, you start to wonder if you made the right choice.\nYou walk for hours to no end and you are still in the mysterious forest with no way out.\nYou continue walking and suddenly you notice something sparkling in the distance...\n");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("What do you wish to do?\n1. Go see what's sparkling in the distance\n2. Steer off the path to avoid the sparkling object\n3. Stay where you are for a while to see if something happens to the object");
                string cmd = Console.ReadLine();

                if (cmd == "1")
                {
                    Console.WriteLine("You slowly start walking torwards the sparkling object\nAs you get closer, you see what the sparkling object really is, it appears to be an old weapon\nYou pick up the weapon and feel and immense power run through you, you drop the weapon because of shock, but pick it up right after that\nYou try swing the weapon a few times with ease, it generates powerful winds with every swings");
                    Console.WriteLine();                    
                    Console.WriteLine("While trying out the weapon a Water Dragon has come close to attack you\nThe battle begins with the dragon!");
                    Console.WriteLine("\nWhat do you wish to do?\n1. Attack\n2. Block");
                    while (true)
                    {
                        string käsk = Console.ReadLine();
                        
                        if (käsk == "1")
                        {
                            Random random = new Random();
                            combat.Fight("BossMob");
                            koletised.BossMob();
                            var damage = random.Next(statid.ATK - 6, statid.ATK + 3);
                            damage = damage + 4000;
                            koletised.HP = koletised.HP - damage;
                            Console.WriteLine("You deal " + damage + " damage to the enemy");
                            Console.WriteLine("The enemy has " + koletised.HP + " health left.\n");
                            if (koletised.HP <= 0)
                            {
                                Console.WriteLine("The monster starts turning to dust as you kill it");                                
                                Console.WriteLine("Right after you killed the Water Dragon the old ghost-man reappears and starts talking to you\n'Thank you adventurer as you have saved this forest from the Water Dragons torment'\nThe old ghost-man calls for a talking griffin who is waiting for you to get on its back to get you back home");
                                Console.WriteLine("THE END!");

                                break;
                            }
                        }

                        else if (käsk == "2")
                        {
                            Console.WriteLine("You blocked the attack and received 0 damage!");
                        }

                        else
                        {
                            Console.WriteLine("You didn't choose a valid command!");
                        }
                    }
                }
                else if (cmd == "2")
                {
                    Console.WriteLine("You choose to run off the path into the forest to avoid the sparkling object\n");
                    Console.WriteLine("After walking for a while in the forest you notice that you're lost and don't know the way back to the path\nYou've been lost for so long that you don't even know how long it's been since then\nYou start to feel weakened because of hunger and dehydration\nWhile taking a small break you are ambushed by a goblin\n");
                    Console.WriteLine("You are unable to run away and the only option is to fight\n");
                    Console.WriteLine("What do you do?\n1. Attack");

                    string vastus = Console.ReadLine();
                    combat.Fight("Mob2");
                    koletised.Mob2();
                    while (vastus == "1")
                    {
                        int ms = 2000;
                        
                        Random random = new Random();
                        var damage = random.Next(statid.ATK - 8, statid.ATK - 5);
                        var MobDamage = random.Next(koletised.ATK - 2, koletised.ATK + 3);
                        var elud = statid.HP - MobDamage;
                        var MobElud = koletised.HP - damage;
                        Console.WriteLine("The monster deals " + MobDamage + " damage!");
                        Console.WriteLine("You have " + elud + " health left!");
                        Thread.Sleep(ms);
                        Console.WriteLine("You deal " + damage + " damage!");
                        Console.WriteLine("The monster has " + MobElud + " health left!");
                        Thread.Sleep(ms);
                        Console.WriteLine("The monster deals " + MobDamage + " damage!");
                        Console.WriteLine("You have " + elud + " health left!");
                        if (elud == 0 || MobElud == 0)
                        {
                            Console.WriteLine("You have died!\nTHE END!");
                            break;
                        }

                        break;
                        
                    }

                }
                else if (cmd == "3")
                {
                    Console.WriteLine("You choose to stay where you are for a while to see if something unusual happens to the object\nWhile you wait to see if something unusual happens to the sparkling object you are attacked by a Water Dragon");
                    Console.WriteLine("What do you wish to do?\n1. Fight the Water Dragon\n2. Run towards the sparkling object\n3. Run into the forest\n4. Run under the Water dragon and try to hide yourself");
                    string vastus = Console.ReadLine();
                    while (vastus == "1")
                    {
                        Random random = new Random();
                        combat.Fight("BossMob");
                        koletised.BossMob();
                        var damage = random.Next(statid.ATK - 5, statid.ATK + 3);
                        var MobDamage = random.Next(koletised.ATK - 10, koletised.ATK + 10);
                        var elud = statid.HP - MobDamage;
                        var MobElud = koletised.HP - damage;
                        Console.WriteLine("You deal " + damage + " to the Water Dragon!");
                        Console.WriteLine("The Water Dragon has " + koletised.HP + " health left!");
                        int ms = 2000;
                        Thread.Sleep(ms);
                        Console.WriteLine("The Water Dragon attacks you for " + MobDamage + " damage!");
                        Console.WriteLine("You have " + elud + " health left!");
                        Thread.Sleep(ms);
                        Console.WriteLine("The Water Dragon has brutally killed you!\nTHE END!");
                        break;
                    }
                    while (vastus == "2")
                    {
                        Console.WriteLine("You choose to run towards the sparkling object to escape the dragon");
                        Console.WriteLine("You pick up the sparkling object and the fight begins!");
                        fight:
                        Console.WriteLine("What do you do?\n1. Attack\n2. Block");
                        string käsk = Console.ReadLine();

                        if (käsk == "1")
                        {
                            Random random = new Random();
                            combat.Fight("BossMob");
                            koletised.BossMob();
                            var damage = random.Next(statid.ATK - 6, statid.ATK + 3);
                            damage = damage + 4000;
                            koletised.HP = koletised.HP - damage;
                            Console.WriteLine("You deal " + damage + " damage to the enemy");
                            Console.WriteLine("The enemy has " + koletised.HP + " health left.\n");
                            if (koletised.HP <= 0)
                            {
                                Console.WriteLine("The monster starts turning into dust as you kill it");                                
                                Console.WriteLine("Right after you killed the Water Dragon the old ghost-man reappears and starts talking to you\n'Thank you adventurer as you have saved this forest from the Water Dragons torment'\nThe old ghost-man calls for a talking griffin who is waiting for you to get on its back to get you back home");
                                Console.WriteLine("THE END!");

                                break;
                            }
                        }

                        else if (käsk == "2")
                        {
                            Console.WriteLine("You blocked the attack and received 0 damage!");
                            Console.WriteLine("You have " + statid.HP + " health left!");
                            goto fight;
                        }

                        else
                        {
                            Console.WriteLine("You didn't choose a valid command!");
                        }
                    }
                    while (vastus == "3")
                    {
                        Console.WriteLine("You decide to run into the forest to escape from the dragon\nYou run for a while and notice that you're being followed by 2 goblins\nYou continue running quivering in fear from the Water Dragon\nAs you look back you at the goblins and the Water Dragon in the distance you fall off the cliff which you didn't notice because you were looking back and die\nTHE END!");
                        break;
                    }
                    while (vastus == "4")
                    {
                        Console.WriteLine("You decide to try and hide yourself under the Water Dragon\nYou start running towards the Water Dragon to get under it\nYou manage to get under it, but the Water Dragon stands up on two feet and grabs you with one hand\nThe Water Dragon roars in your face, making you quiver in fear and faint\nThe Water Dragon throws you in its mouth and swallows you whole\nTHE END!");
                        break;
                    }
                }

            }
            else if (path == "4") //SEE ON KERDI OMA
            {

            }
            Console.ReadLine();
        }
    }
}
