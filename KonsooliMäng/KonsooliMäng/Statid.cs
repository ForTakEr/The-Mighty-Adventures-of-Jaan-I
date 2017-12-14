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
        public int MaxHP;
        public int MaxMP;

        public void Knight()
        {
            HP = 60;
            MP = 20;
            ATK = 12;
            Klass = "Knight";
            MaxHP = HP;
            MaxMP = MP;
        }

        public void Mage()
        {
            HP = 50;
            MP = 35;
            ATK = 7;
            Klass = "Mage";
            MaxHP = HP;
            MaxMP = MP;
        }

        public void Archer()
        {
            HP = 55;
            MP = 20;
            ATK = 10;
            Klass = "Archer";
            MaxHP = HP;
            MaxMP = MP;
        }

        public void Rogue()
        {
            HP = 48;
            MP = 30;
            ATK = 12;
            Klass = "Rogue";
            MaxHP = HP;
            MaxMP = MP;
        }
    }
}
