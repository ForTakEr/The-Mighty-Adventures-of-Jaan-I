using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace KonsooliMäng
{
    class CombatSystem
    {
        public void Fight(int damage, int health, string monster, Statid statid, bool Dog, bool Gold)
        {
            Random random = new Random();
            SoundPlayer BattleMusic = new SoundPlayer();
            BattleMusic.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\BattleMusic.wav";
            BattleMusic.PlayLooping();
            int ms = 1500;
            while (true)
            {
                if (statid.Klass == "Mage")
                {
                    if (statid.HP >= 10)
                    {
                        Console.Write("You have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(statid.HP + " HP ");
                        Console.ResetColor();
                        Console.Write("and ");
                        if (statid.MP > 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(statid.MP + " MP");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("and ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(statid.MP + " MP");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write("You have ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(statid.HP + " HP ");
                        Console.ResetColor();
                        Console.Write("and ");
                        if (statid.MP > 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(statid.MP + " stamina");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(statid.MP + " stamina");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    if (statid.HP >= 10)
                    {
                        Console.Write("You have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(statid.HP + " HP ");
                        Console.ResetColor();
                        Console.Write("and ");
                        if (statid.MP > 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(statid.MP + " stamina");
                            Console.ResetColor();
                            Console.WriteLine();  
                        }
                        else
                        {
                            Console.Write("and ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(statid.MP + " stamina");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write("You have ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(statid.HP + " HP ");
                        Console.ResetColor();
                        Console.Write("and ");
                        if (statid.MP > 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(statid.MP + " stamina");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(statid.MP + " stamina");
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                    }
                }
                Console.Write("The monster has ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(health + " HP");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("\nWhat would you like to do?\n1. Fight\n2. Block\n3. Rest\n4. Run away");
                if (statid.Klass == "Mage")
                {
                    Console.WriteLine("5. Heal");
                    if (Dog && Gold)
                    {
                        Console.WriteLine("6. Throw gold at the dragon\n7. Have your dog bark at the dragon");
                    }
                    else if (Dog)
                    {
                        Console.WriteLine("6. Have your dog bark at the dragon");
                    }
                    else if (Gold)
                    {
                        Console.WriteLine("6. Throw gold at the dragon");
                    }
                }
                else
                {
                    if (Dog && Gold)
                    {
                        Console.WriteLine("5. Throw gold at the dragon\n6. Have your dog bark at the dragon");
                    }
                    else if (Dog)
                    {
                        Console.WriteLine("5. Have your dog bark at the dragon");
                    }
                    else if (Gold)
                    {
                        Console.WriteLine("5. Throw gold at the dragon");
                    }
                }
                Console.WriteLine();
                string vastus = Console.ReadLine();
                Console.WriteLine();
                if (vastus == "1")
                {
                    var DamageToMonster = random.Next(statid.ATK - 1, statid.ATK + 2);
                    var DamageFromMonster = random.Next(damage - 1, damage + 1);
                    statid.MP--;
                    if (DamageToMonster == statid.ATK + 2)
                    {
                        Console.Write("You deal ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(DamageToMonster + " damage");
                        Console.ResetColor();
                        Console.Write(" against " + monster);
                        Console.WriteLine();
                        health -= DamageToMonster;
                        if (statid.Klass != "Mage")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("CRITICAL HIT\nYou regain stamina");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("CRITICAL HIT\nYou regain one MP");
                            Console.ResetColor();
                        }
                        if (health <= 0)
                        {
                            Console.WriteLine("You have defeated " + monster);
                            break;
                        }
                        Console.Write("You get hit for ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(DamageFromMonster + " damage");
                        Console.ResetColor();
                        Console.WriteLine();
                        statid.HP -= DamageFromMonster;
                        if (statid.HP <= 0)
                        {
                            Console.WriteLine("GAME OVER, YOU HAVE DIED");
                            Console.WriteLine("Press enter to try again");
                            Console.ReadLine();
                            break;
                        }
                        statid.MP++;
                    }
                    else
                    {
                        Console.Write("You deal ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(DamageToMonster + " damage");
                        Console.ResetColor();
                        Console.Write(" against " + monster);
                        Console.WriteLine();
                        health -= DamageToMonster;
                        if (health <= 0)
                        {
                            Console.WriteLine("You have defeated " + monster);
                            break;
                        }
                        Console.Write("You get hit for ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(DamageFromMonster + " damage");
                        Console.ResetColor();
                        Console.WriteLine();
                        statid.HP -= DamageFromMonster;
                        if (statid.HP <= 0)
                        {
                            Console.WriteLine("GAME OVER, YOU HAVE DIED");
                            Console.WriteLine("Press enter to try again");
                            Console.ReadLine();
                            break;
                        }
                    }
                }
                else if (vastus == "2")
                {
                    int DamageFromMonster = random.Next(0, 3);
                    statid.HP -= DamageFromMonster;
                    if (DamageFromMonster == 0)
                    {
                        Console.WriteLine("You block succesfuly and the monster doesn't deal any damage");
                    }
                    else
                    {
                        Console.WriteLine("You try to block, but the monster deals you for " + DamageFromMonster + " damage");
                    }
                    if (statid.HP <= 0)
                    {
                        Console.WriteLine("GAME OVER, YOU HAVE DIED");
                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
                        break;
                    }
                }
                else if (vastus == "3")
                {
                    statid.HP += random.Next(2, 15);
                    statid.MP += random.Next(5, 10);
                    if (statid.HP > statid.MaxHP)
                    {
                        statid.HP = statid.MaxHP;
                    }
                    if (statid.MP > statid.MaxMP)
                    {
                        statid.MP = statid.MaxMP;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (statid.Klass == "Mage")
                    {
                        Console.WriteLine("You now have " + statid.HP + " HP and " + statid.MP + " MP");
                    }
                    else
                    {
                        Console.WriteLine("You now have " + statid.HP + " HP and " + statid.MP + " stamina");
                    }
                    Console.ResetColor();
                    var DamageFromMonster = random.Next(damage - 1, damage + 1);
                    statid.HP -= DamageFromMonster;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The monster hit you while you were resting, you lost " + DamageFromMonster + " HP");
                    Console.ResetColor();
                    if (statid.HP <= 0)
                    {
                        Console.WriteLine("GAME OVER, YOU HAVE DIED");
                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
                        break;
                    }
                }
                else if (vastus == "4")
                {
                    Console.WriteLine("You can't run from this fight");
                }
                else if (vastus == "5" && statid.Klass == "Mage")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You regain 15 HP and lose 5 MP");
                    Console.ResetColor();
                    statid.HP += 15;
                    statid.MP -= 5;
                    if (statid.HP > statid.MaxHP)
                    {
                        statid.HP = statid.MaxHP;
                    }
                    if (statid.MP > statid.MaxMP)
                    {
                        statid.MP = statid.MaxMP;
                    }
                }
                else if (vastus == "6" && statid.Klass == "Mage" && Dog && Gold)
                {
                    Console.WriteLine("Overcome by greed the dragon picks up the gold and flies away");
                    break;
                }
                else if (vastus == "7" && statid.Klass == "Mage" && Dog && Gold)
                {
                    Console.WriteLine("Your dog barks at the dragon with great fierceness, the dragon flies away");
                    break;
                }
                else if (vastus == "6" && Dog || vastus == "5" && Dog)
                {
                    Console.WriteLine("Your dog barks at the dragon with great fierceness, the dragon flies away");
                    break;
                }
                else if (vastus == "6" && Gold || vastus == "5" && Gold)
                {
                    Console.WriteLine("Overcome by greed the dragon picks up the gold and flies away");
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose one of the options");
                }
                Thread.Sleep(ms);
                Console.Clear();
            }
            BattleMusic.Stop();
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
