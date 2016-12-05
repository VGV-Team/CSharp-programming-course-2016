using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Entity
    {
        public string name;
        public int HP;

        public int strength;
        public int money;

        public void heal()
        {
            HP = HP + money;
            money = 0;
        }


        public void attack(Entity enemy)
        {
            enemy.HP = enemy.HP - strength;
            Console.WriteLine(name + " (" + HP + ")" + " napada " + enemy.name + " (" + enemy.HP + ") napada.");

            money = money + strength / 2;
        }

        public bool isAlive()
        {
            if (HP > 0) return true;
            else return false;
        }
    }
}
