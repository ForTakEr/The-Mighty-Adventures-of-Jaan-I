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

        //String klassiga saab klasside järgi panna mana ja hp jne.

        public void Knight()
        {
            HP = 20;
            MP = 5;
        }

        public void Mage()
        {
            HP = 15;
            MP = 25;
        }

        public void Archer()
        {
            HP = 17;
            MP = 7;
        }

        public void Rogue()
        {
            HP = 16;
            MP = 20;
        }
    }
}
