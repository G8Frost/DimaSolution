using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster
    {
        public int HP;
        public int Dmg;
        public int Prot;
        public string Name;
        public void GetDamage(int countDamage)
        {
            HP -= countDamage + Prot;
        }
        public bool IsLive
        {
            get
            {
                return HP > 0;
            }
        }
        public Monster(string name, int hp)
        {
            Name = name;
            HP = hp;
        }

    }
}
