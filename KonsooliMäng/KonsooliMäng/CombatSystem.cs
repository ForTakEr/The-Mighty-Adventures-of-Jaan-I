using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsooliMäng
{
    class CombatSystem : Koletised
    {
        public void Fight(string enemy)
        {
            Koletised koletised = new Koletised();

            if (enemy == "Mob1")
            {
                koletised.Mob1();                
            }
            else if (enemy == "Mob2")
            {
                koletised.Mob2();
            }
            else if (enemy == "Mob3")
            {
                koletised.Mob3();
            }
            else if (enemy == "BossMob")
            {
                koletised.BossMob();
            }

            
            Console.WriteLine("The monster has " + koletised.HP + " health!\nThe monster can deal up to " + koletised.ATK + " damage!\n");
            
        }
    }
}
