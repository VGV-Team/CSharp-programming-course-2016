using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Hero
    {
        public string name;
        public int HP;
        public int strength;

        public void attack(Monster enemy)
        {
            enemy.HP = enemy.HP - strength;
            Console.WriteLine(name + " ("+ HP +")" + " napada " + enemy.name + " (" + enemy.HP + ") napada.");
        }

        public bool isAlive()
        {
            if (HP > 0) return true;
            else return false;
        }
    }
}
