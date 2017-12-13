using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsooliMäng
{
    class Statid
    {
        public int HP;
        public int MP;
        public int ATK;
        public string Klass;

        public void Knight()
        {
            HP = 60;
            MP = 20;
            ATK = 12;
            Klass = "Knight";
        }

        public void Mage()
        {
            HP = 50;
            MP = 35;
            ATK = 7;
            Klass = "Mage";
        }

        public void Archer()
        {
            HP = 55;
            MP = 20;
            ATK = 10;
            Klass = "Archer";
        }

        public void Rogue()
        {
            HP = 48;
            MP = 30;
            ATK = 12;
            Klass = "Rogue";
        }
    }
}
