using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Monster
    {
        public string name;
        public int HP;
        public int strength;

        public void attack(Hero hero)
        {
            hero.HP = hero.HP - strength;
            Console.WriteLine(name + " (" + HP + ")" + " napada " + hero.name + " (" + hero.HP + ") napada.");
        }

        public bool isAlive()
        {
            if (HP > 0) return true;
            else return false;
        }
    }
}
