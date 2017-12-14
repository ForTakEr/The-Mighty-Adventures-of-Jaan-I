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
            while (true)
            {
                int ms = 1000;
                Statid statid = new Statid();
                Random randomNumber = new Random();
                CombatSystem combat = new CombatSystem();
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.WriteLine("The Mighty Adventures of Jaanus!");
                Console.WriteLine("Made by Moka Studio™ 2017\n");
                Thread.Sleep(ms);
                Console.Clear();
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
                        Console.WriteLine("Not an option (...the duck?)\n");
                    }
                    Console.Clear();
                }

                while (true)
                {

                    Console.Clear();
                    Console.WriteLine("You wake up in a strange forest, everything around you is dark and creepy... you hear thunder in the distance. You clutch your weapon in fear. It's frightening, what do you do?\n1. Look around\n2. Take a rest");
                    string response = Console.ReadLine();
                    if (response == "1")
                    {
                        break;
                    }
                    else if (response == "2")
                    {
                        Console.WriteLine("You have more important things to do than that.");
                        Thread.Sleep(ms);
                    }
                    else
                    {
                        Console.WriteLine("Please choose one of the options");
                    }
                }
                Console.Clear();
                string path;
                while (true)
                {
                    Console.Clear();
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
                        Console.WriteLine("Please choose one of the options\n");
                    }
                    Thread.Sleep(ms);
                    Console.Clear();
                }
                if (path == "2") //SEE ON GERDI OMA
                {
                    Console.Clear();
                    string tegu = "1";
                    Console.WriteLine("As you walk the left path you feel a sense of dread, you wonder if you made the right choice, it probably doesn’t matter anyway, that old fart was just playing games with me, but that fog is really worrying.\nHours seem to pass by uneventful when you realize that you have already passed this grove.\n1. Start running\n2. Inspect the grove\n");
                    string vastus = Console.ReadLine();
                    Console.Clear();
                    if (vastus == "1")
                    {
                        Console.WriteLine("It’s already dark out when you pass the grove for the 3rd time, but this time is different, the stone in the middle of the grove has moved to the far left.\n1. Inspect the stone\n2. Stand still\n");
                        string response = Console.ReadLine();
                        Console.Clear();
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
                        Console.Clear();
                        if (sõna == "1")
                        {
                            Console.WriteLine("While inspecting the stone it starts to crumble and shake, the stone turns to rubble revealing an unknown monster, that must be the reason for me running around like an idiot. It charges\n");
                        }
                        else if (sõna == "2")
                        {
                            Console.WriteLine("It’s already dark out when you pass the grove for the 3rd time, but this time is different, the stone in the middle of the grove has moved to the far left.\n1. Inspect the stone\n2. Stand still\n");
                            string response = Console.ReadLine();
                            Console.Clear();
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
                    Thread.Sleep(ms);
                    combat.Fight(5, 50, "Stone golem", statid, false, false);
                    Console.WriteLine("With the monster slain the fog dissipates and your mind feels clearer, you feel confident in your ability to leave the forest, but at the same time you feel tired enough to fall asleep right where you’re standing\n1. Continue on the trail\n2. Rest at the grove\n");
                    vastus = Console.ReadLine();
                    Console.Clear();
                    if (vastus == "1")
                    {
                        Console.WriteLine("You walk on the trail in the middle of the night and hear shuffling in a nearby bush, a puma plunges at you.");
                        Thread.Sleep(ms);
                        combat.Fight(8, 70, "Puma", statid, false, false);
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
                    Console.Clear();
                    if (vastus != "1")
                    {
                        Console.WriteLine("You head back to the forest and see multiple monsters, one of them attacks you\n");
                        Thread.Sleep(ms);
                        combat.Fight(5, 50, "Monster", statid, false, false);
                    }
                    string scenario = "";
                    bool dog = false;
                    while (true)
                    {
                        Console.WriteLine("While walking through the field you come across a wild dog, limping.\n1. Kill the dog like a heartless person\n2. Feed the dog and patch him up\n3. Leave him there like the cold person you are\n");
                        vastus = Console.ReadLine();
                        Console.Clear();
                        if (vastus == "1")
                        {
                            Console.WriteLine("The dog looks at you with sad eyes, are you sure you want to do this?\n1. YES\n2. No, i was kidding");
                            string tapmine = Console.ReadLine();
                            Console.Clear();
                            if (tapmine == "1")
                            {
                                Console.WriteLine("You try to attack the dog, but you end up having a heart attack, the gods were not pleased with your actions");
                                Console.WriteLine("-10 000 HP");
                                Console.ReadLine();
                                Environment.Exit(0);
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (vastus == "2")
                        {
                            Console.WriteLine("You patch up the dog and it wags it’s tail in delight. You have earned a loyal companion (he won’t fight for you though, it’s a dog don’t go throwing it at enemies, love it)");
                            dog = true;
                            break;
                        }
                        else if (vastus == "3")
                        {
                            Console.WriteLine("You leave the dog");
                            break;
                        }
                    }
                    if (dog == true)
                    {
                        Console.WriteLine("With your trusty companion {INSERT NAME HERE} by your side you reach the end of the field where you find a distressed woman.\n1. Go ask the woman what's wrong\n2. Continue on your path, you have more important things to do");
                        vastus = Console.ReadLine();
                        Console.Clear();

                        if (vastus == "1")
                        {
                            Console.WriteLine("You approach the woman and ask her what’s wrong\n“Well you see kind sir, i lost my puppy and i can’t seem to find her”\n1. Is this your puppy?\n2. What puppy? i don't know what you're talking about\n");
                            tegu = Console.ReadLine();
                            Console.Clear();
                            if (tegu == "1")
                            {
                                scenario = "A";
                            }
                            else if (tegu == "2")
                            {
                                Console.WriteLine("She sees the dog behind you...\n1. Cover it up some more\n2. Admit that the dog might be her puppy\n");
                                string valik = Console.ReadLine();
                                Console.Clear();
                                if (valik == "1")
                                {
                                    Console.WriteLine("“Isabella is that you?”\n1. No, that's my dog {INSERT NAME HERE}\n2. I think it might be your puppy");
                                    string action = Console.ReadLine();
                                    Console.Clear();
                                    if (action == "1")
                                    {
                                        Console.WriteLine("Oh, i’m sorry she reminds me so much of her and i was willing to give 10 000 gold to the person who found her\n1. Give her the puppy\n2. KILL HER AND TAKE THE MONEY\n3. Leave her there\n");
                                        string ok = Console.ReadLine();
                                        Console.Clear();
                                        if (ok == "1")
                                        {
                                            scenario = "A";
                                        }
                                        else if (ok == "2")
                                        {
                                            scenario = "C";
                                        }
                                        else if (ok == "3")
                                        {
                                            scenario = "B";
                                        }
                                    }
                                    else if (action == "2")
                                    {
                                        scenario = "A";
                                    }
                                }
                                else if (valik == "2")
                                {
                                    scenario = "A";
                                }
                            }
                        }
                        else if (vastus == "2")
                        {
                            scenario = "B";
                        }
                    }
                    else if (dog == false)
                    {
                        Console.WriteLine("Feeling like a little bad after leaving the dog you reach the end of the field where you find a distressed woman.\n1. Go ask the woman what's wrong\n2. Continue on your path, you have more important things to do\n");
                        vastus = Console.ReadLine();
                        Console.Clear();
                        if (vastus == "1")
                        {
                            while (true)
                            {
                                Console.WriteLine("You approach the woman and ask her what’s wrong\n“Well you see kind sir, i lost my puppy and i can’t seem to find her”\n1. Oh, i left her to die\n2. Never heard of no puppy\n");
                                tegu = Console.ReadLine();
                                Console.Clear();
                                if (tegu == "1")
                                {
                                    Console.WriteLine("“You… you did what?”\n1. I left her to die in the forest i was in, she was badly hurt\n2. JK\n");
                                    string action = Console.ReadLine();
                                    Console.Clear();
                                    if (action == "1")
                                    {
                                        Console.WriteLine("“OH NO ISABELLA” she screams as she runs past you to the forest");
                                        scenario = "B";
                                        break;
                                    }
                                    else if (action == "2")
                                    {
                                        Console.WriteLine("“That’s a cruel joke”");
                                    }
                                }
                                else if (tegu == "2")
                                {
                                    Console.WriteLine("“Okay… Sorry to bother you” ");
                                    scenario = "B";
                                    break;
                                }
                            }
                        }
                        else if (vastus == "2")
                        {
                            scenario = "B";
                        }
                    }
                    if (scenario == "A" && dog == true)
                    {
                        Console.WriteLine("“Oh Isabella how i have missed you. please take this for your trouble” You got 10 000 gold.\n“If you’re looking for the town of Cakinass it’s 5 km to the north of here” Cakinass, the name sounds so familiar on your tongue, you feel like it might be your home\nYou head to the town of Cakinass where a large water dragon is looming over the church tower.It flies at you.\n");
                        Thread.Sleep(ms);
                        combat.Fight(100, 2000, "Dragon", statid, false, true);
                        Console.WriteLine("HUZZAH VICTORY");
                    }
                    else if (scenario == "B" && dog == true)
                    {
                        Console.WriteLine("You head toward where you were going before all the trouble and find yourself in a town with a water dragon looming over the church watch tower. It flies at you.\n");
                        Thread.Sleep(ms);
                        combat.Fight(100, 2000, "Dragon", statid, dog, false);
                    }
                    else if (scenario == "A" && dog == true)
                    {
                        Console.WriteLine("Feeling the gold in your satchel and the dog by your side makes you feel invincible as you make it to the town of Cakinass, apparently. There you notice a large water dragon atop a church tower. It flies at you.\n");
                        Thread.Sleep(ms);
                        combat.Fight(100, 2000, "Dragon", statid, dog, true);
                    }
                    else if (scenario == "B" && dog == false)
                    {
                        Console.WriteLine("You head toward where you were going before all the trouble and find yourself in a town with a water dragon looming over the church watch tower. It flies at you.\n");
                        Thread.Sleep(ms);
                        combat.Fight(100, 2000, "Dragon", statid, dog, false);
                    }
                }
                else if (path == "3") //SEE ON SIMO OMA
                {
                    Console.Clear();
                    Console.WriteLine("As you start walking down the middle path, you start to wonder if you made the right choice.\nYou walk for hours to no end and you are still in the mysterious forest with no way out.\nYou continue walking and suddenly you notice something sparkling in the distance...\n");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("What do you wish to do?\n1. Go see what's sparkling in the distance\n2. Steer off the path to avoid the sparkling object\n3. Stay where you are for a while to see if something happens to the object");
                    string cmd = Console.ReadLine();

                    if (cmd == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("You slowly start walking torwards the sparkling object\nAs you get closer, you see what the sparkling object really is, it appears to be an old weapon\nYou pick up the weapon and feel and immense power run through you, you drop the weapon because of shock, but pick it up right after that\nYou try swing the weapon a few times with ease, it generates powerful winds with every swings");
                        Console.WriteLine();
                        Console.WriteLine("While trying out the weapon a Water Dragon has come close to attack you\nThe battle begins with the dragon!");
                        statid.ATK += 4000;
                        statid.HP += 10000;
                        combat.Fight(100, 2000, "Water Dragon", statid, false, false);
                        Console.WriteLine("The monster starts turning to dust as you kill it");
                        Console.WriteLine("Right after you killed the Water Dragon the old ghost-man reappears and starts talking to you\n'Thank you adventurer as you have saved this forest from the Water Dragons torment'\nThe old ghost-man calls for a talking griffin who is waiting for you to get on its back to get you back home");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else if (cmd == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("You choose to run off the path into the forest to avoid the sparkling object\n");
                        Console.WriteLine("After walking for a while in the forest you notice that you're lost and don't know the way back to the path\nYou've been lost for so long that you don't even know how long it's been since then\nYou start to feel weakened because of hunger and dehydration\nWhile taking a small break you are ambushed by a goblin\n");
                        Console.WriteLine("You are unable to run away and the only option is to fight\n");
                        combat.Fight(100, 2000, "Water Dragon", statid, false, false);
                    }
                    else if (cmd == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("You choose to stay where you are for a while to see if something unusual happens to the object\nWhile you wait to see if something unusual happens to the sparkling object you are attacked by a Water Dragon");
                        Console.WriteLine("What do you wish to do?\n1. Fight the Water Dragon\n2. Run towards the sparkling object\n3. Run into the forest\n4. Run under the Water dragon and try to hide yourself");
                        string vastus = Console.ReadLine();
                        Console.Clear();
                        while (vastus == "1")
                        {
                            combat.Fight(100, 2000, "Dragon", statid, false, false);
                            break;
                        }
                        while (vastus == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("You choose to run towards the sparkling object to escape the dragon");
                            Console.WriteLine("You pick up the sparkling object and the fight begins!\n");
                            statid.ATK += 4000;
                            statid.HP += 10000;
                            combat.Fight(100, 2000, "Dragon", statid, false, false);
                            Console.WriteLine("The monster starts turning into dust as you kill it");
                            Console.WriteLine("Right after you killed the Water Dragon the old ghost-man reappears and starts talking to you\n'Thank you adventurer as you have saved this forest from the Water Dragons torment'\nThe old ghost-man calls for a talking griffin who is waiting for you to get on its back to get you back home");
                            break;
                        }
                        while (vastus == "3")
                        {
                            Console.Clear();
                            Console.WriteLine("You decide to run into the forest to escape from the dragon\nYou run for a while and notice that you're being followed by 2 goblins\nYou continue running quivering in fear from the Water Dragon\nAs you look back you at the goblins and the Water Dragon in the distance you fall off the cliff which you didn't notice because you were looking back and die");
                            break;
                        }
                        while (vastus == "4")
                        {
                            Console.Clear();
                            Console.WriteLine("You decide to try and hide yourself under the Water Dragon\nYou start running towards the Water Dragon to get under it\nYou manage to get under it, but the Water Dragon stands up on two feet and grabs you with one hand\nThe Water Dragon roars in your face, making you quiver in fear and faint\nThe Water Dragon throws you in its mouth and swallows you whole");
                            break;
                        }
                    }

                }
                else if (path == "4") //SEE ON KERDI OMA

                {
                    Console.Clear();
                    Console.WriteLine("You embark on your journey, you start walking towards your path. \nTime passes \n\nYour mind wanders if this was the right choice, your heart stays true \nbut your mind questions. \n“Thou ought thunk he chosen the rightest of paths, ought to be'ist thar complicatest“ \nYou begin to see green leaves and green trees, night starts to overwhelm the sky. \nYou feel tired. You are thinking of making a camp");
                    Console.WriteLine("\nAre You going to find a campsite or going to get firewood. \n1.Get wood, then find camp \n2.Find campsite, then firewood");

                        while (true)
                        {
                            string valik = Console.ReadLine();
                            if (valik == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You search the forest, to find some wood. \nYou found yourself some firewood. \nYou start to look for a campsite, you found it. It isn’t perfect, but it will do.");
                                break;
                            }
                            else if (valik == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("You search the forest for a campsite. \nYou found a nice place near a river. \nYou put your belongings on the ground and go to find firewood. \n\nYou found some firewood, but not much.");
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Choose the right number");
                                break;
                            }
                        }

                        while (true)

                        {
                            Console.Clear();
                            Console.WriteLine("You're sitting by the fire, you hear cracking sounds in the bushes. what do you do? \n1. Investigate \n2. Ignore.");
                            string valik2 = Console.ReadLine();
                            if (valik2 == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You grab your weapon, hold it tight and ready to fight. You walk to the bushes, open them and \nslash whatever is inside. \nThere was nothing there. \nYou think of yourself as such a fool, walk back and hear it again.. This time you ignore it. \nYou Hear a klonk, your head aches, \nyou fall down. \neverything fades..");
                                break;
                            }

                            else if (valik2 == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("You ignore it, \nUnexpectedly you Hear a klonk, your head aches. \nYou fall down. \neverything fades..");
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Choose the right number");
                            }
                        }

                        while (true)
                        {
                            Console.WriteLine("\n\nYou are unconcious.. \n1.Try to wake up.");
                            string valik3 = Console.ReadLine();
                            Console.Clear();
                            if (valik3 == "1")
                            {

                                Console.WriteLine("You opened your eyes.");
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Choose the only option");
                            }

                        }
                        while (true)
                        {

                            Console.WriteLine("You hear some keys rambling in the distance. \n1.Try to move. \n2.Try Not to move.");
                            string valik4 = Console.ReadLine();
                            if (valik4 == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("You stayed still, you hear someone walking towards you.");
                                break;
                            }
                            else if (valik4 == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You tried to move, but you are tired. You hear someone walking towards you.");
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Choose something");
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("He lits up a torch, looks for his keys and opens your cell. \nNext thing he does is he puts your food in the corner. You see an oppurtunity to grab his knife and kill him. \nWhat do you do? \n1. Try to grab his knife \n2. Try not to make a sound");
                        while (true)
                        {
                            string valik5 = Console.ReadLine();
                            if (valik5 == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You grabbed his knife, he noticed. What do you do? \n1. Stab him. \n2. Threaten him.");
                                break;
                            }
                            if (valik5 == "2")
                            {
                                Console.Clear();
                                Console.WriteLine("You stayed still");
                                Console.WriteLine("He walks up to you, he notices you have moved. \nHe grabs his knife, What do you do? \n1. Try to block him from trying to stab you");
                                string valik7 = Console.ReadLine();
                                while (true)
                                {
                                    if (valik7 == "1")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("You failed to block him.");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("YOU HAVE DIED!");
                                        Console.ResetColor();
                                    Console.WriteLine("Press enter to try again");
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Choose again");
                                    }
                                }

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Choose something");
                            }
                            break;
                        }
                        string valik6 = Console.ReadLine();
                        while (valik6 == "1")
                        {
                            if (valik6 == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("You stabbed him");
                                break;
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Choose again");
                            }
                        }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("YOU HAVE DIED");
                    Console.ResetColor();
                    Thread.Sleep(ms);
                    Console.Clear();
                }
            }
        } 
    }
}

