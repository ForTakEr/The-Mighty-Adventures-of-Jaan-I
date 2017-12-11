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
                Console.WriteLine(koletised.HP);
            }
            
            Console.WriteLine(koletised.HP);
        }
    }
}
