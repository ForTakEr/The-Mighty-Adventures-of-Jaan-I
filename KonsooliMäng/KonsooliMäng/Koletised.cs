using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsooliMäng
{
    class Koletised
    {
        public int HP;
        public int ATK;

        public void Mob1()
        {
            HP = 50;
            ATK = 5;
        }

        public void Mob2()
        {
            HP = 70;
            ATK = 8;
        }

        public void Mob3()
        {
            HP = 20;
            ATK = 2;
        }

        public void BossMob()
        {
            HP = 2000;
            ATK = 100;
        }
    }
}
