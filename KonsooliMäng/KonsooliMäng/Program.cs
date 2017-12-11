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
                Console.WriteLine("As you walk the left path you feel a sense of dread, you wonder if you made the right choice, it probably doesn’t matter anyway, that old fart was just playing games with me, but that fog is really worrying.\nHours seem to pass by uneventful when you realize that you have already passed this grove.\n1. Start running\n2. Inspect the grove\n");
                string vastus = Console.ReadLine();
                if (vastus == "1")
                {
                    Console.WriteLine("It’s already dark out when you pass the grove for the 3rd time, but this time is different, the stone in the middle of the grove has moved to the far left.\n1. Inspect the stone\n2. Stand still\n");
                    string response = Console.ReadLine();
                    if (response == "1")
                    {
                        Console.WriteLine("While inspecting the stone it starts to crumble and shake, the stone turns to rubble revealing an unknown monster, that must be the reason for me running around like an idiot. It charges\n");
                    }
                    else if (response == "2")
                    {
                        Console.WriteLine("While standing still the stone starts to crumble and shake, the stone turns to rubble revealing an unknown monster, that must be the reason for me running around like an idiot. It charges\n");
                    }
                    else
                    {
                        Console.WriteLine("that's not an option, but whatever a monster attacks");
                    }
                }
                else if (vastus == "2")
                {
                    Console.WriteLine("When inspecting the grove you notice a large boulder move a little, you think it might be your mind tricking you\n1. Inspect the boulder\n2. Run away\n");
                    string sõna = Console.ReadLine();
                    if (sõna == "1")
                    {
                        Console.WriteLine("While inspecting the stone it starts to crumble and shake, the stone turns to rubble revealing an unknown monster, that must be the reason for me running around like an idiot. It charges\n");
                    }
                    else if (sõna == "2")
                    {
                        Console.WriteLine("It’s already dark out when you pass the grove for the 3rd time, but this time is different, the stone in the middle of the grove has moved to the far left.\n1. Inspect the stone\n2. Stand still\n");
                        string response = Console.ReadLine();
                        if (response == "1")
                        {
                            Console.WriteLine("While inspecting the stone it starts to crumble and shake, the stone turns to rubble revealing an unknown monster, that must be the reason for me running around like an idiot. It charges\n");
                        }
                        else if (response == "2")
                        {
                            Console.WriteLine("While standing still the stone starts to crumble and shake, the stone turns to rubble revealing an unknown monster, that must be the reason for me running around like an idiot. It charges\n");
                        }
                        else
                        {
                            Console.WriteLine("that's not an option, but whatever a monster attacks");
                        }
                    }
                }

                Random randomNumber = new Random();
                combat.Fight("Mob1");
                Console.WriteLine("What do you do?\n1. Attack the enemy\n2. Flee\n3. Block");
                string tegu = Console.ReadLine();

                if (tegu == "1")
                {
                    //Mob tuleb välja kutsuda muidu ei tööta
                    koletised.Mob1();
                    var damage = randomNumber.Next(statid.ATK - 6, statid.ATK + 2);
                    koletised.HP = koletised.HP - damage;
                    Console.WriteLine(koletised.HP);
                }

                Console.WriteLine("With the monster slain the fog dissipates and your mind feels clearer, you feel confident in your ability to leave the forest, but at the same time you feel tired enough to fall asleep right where you’re standing\n1. Continue on the trail\n2. Rest at the grove\n");
                vastus = Console.ReadLine();
                if (vastus == "1")
                {
                    Console.WriteLine("You walk on the trail in the middle of the night and hear shuffling in a nearby bush, a puma plunges at you.");
                    combat.Fight("Mob2");
                    Console.WriteLine("What do you do?\n1. Attack the enemy\n2. Flee\n3. Block");
                    tegu = Console.ReadLine();

                    if (tegu == "1")
                    {
                        //Mob tuleb välja kutsuda muidu ei tööta
                        koletised.Mob2();
                        var damage = randomNumber.Next(statid.ATK - 6, statid.ATK + 2);
                        koletised.HP = koletised.HP - damage;
                        Console.WriteLine(koletised.HP);
                    }
                    Console.WriteLine("After defeating the puma and walking for hours on end you finally reach the end of the forest, ahead of you is a large field. You feel so exhausted you collapse.");
                    Console.WriteLine("You wake up and it’s the middle of the day, the field hasn’t moved and neither have you, what do you want to do?\n");
                }
                else if (vastus == "2")
                {
                    Console.WriteLine("Feeling fully rested you continue on the trail with nothing of interest happening.");
                    Console.WriteLine("After a few hours of walking you come to the edge of the forest, ahead of you is a large field. What would you like to do?\n");
                }
                Console.WriteLine("1. Cross the field\n2. Head back to the forest\n");
                vastus = Console.ReadLine();
                if (vastus != "1")
                {
                    Console.WriteLine("You head back to the forest and see multiple monsters, one of them attacks you\n");
                    combat.Fight("Mob1");
                    Console.WriteLine("What do you do?\n1. Attack the enemy\n2. Flee\n3. Block");
                    tegu = Console.ReadLine();

                    if (tegu == "1")
                    {
                        //Mob tuleb välja kutsuda muidu ei tööta
                        koletised.Mob1();
                        var damage = randomNumber.Next(statid.ATK - 6, statid.ATK + 2);
                        koletised.HP = koletised.HP - damage;
                        Console.WriteLine(koletised.HP);
                    }
                    Console.WriteLine("After killing the monster you decide to wisen up and walk through the field");
                }
                bool dog = false;
                tagasi:
                Console.WriteLine("While walking through the field you come across a wild dog, limping.\n1. Kill the fucking dog like a heartless son of a bitch\n2. Feed the dog and path him up\n3. Leave him there like the cold bitch (dog pun) you are\n");
                vastus = Console.ReadLine();

                if (vastus == "1")
                {
                    Console.WriteLine("The dog looks at you with sad eyes, are you sure you want to do this?\n1. YES\n2. No, i was kidding");
                    string tapmine = Console.ReadLine();
                    if (tapmine == "1")
                    {
                        Console.WriteLine("You try to attack the dog, but you end up having a heart attack");
                        Console.WriteLine("-10 000 HP");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        goto tagasi;
                    }
                }
                else if (vastus == "2")
                {
                    Console.WriteLine("You patch up the dog and it wags it’s tail in delight. You have earned a loyal companion (he won’t fight for you though, it’s a fucking dog don’t go throwing it at enemies, love it)");
                    dog = true;
                }
                else if (vastus == "3")
                {
                    Console.WriteLine("You leave the dog");
                }
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
