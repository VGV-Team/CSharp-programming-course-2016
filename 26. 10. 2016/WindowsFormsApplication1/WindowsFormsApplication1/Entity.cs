using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Entity
    {
        public int health;
        public int currentStamina;
        public int maxStamina;
        public int lightDamage;
        public int heavyDamage;
        public int level;
        public string name;

        public Entity()
        {
            health = 100;
            currentStamina = 100;
            maxStamina = 100;
            lightDamage = 10;
            heavyDamage = 30;
            level = 1;
            name = "";
        }

        public int LightAttack(Entity monster)
        {
            health = health - monster.lightDamage;
            if (monster.health - lightDamage < 0)
            {
                monster.health = 0;
                currentStamina = currentStamina - 10;
                return monster.health;
            }
            else
            {
                monster.health = monster.health - lightDamage;
                currentStamina = currentStamina - 10;
                return lightDamage;
            }
        }
        public int HeavyAttack(Entity monster)
        {
            health = health - monster.lightDamage;
            if (monster.health - heavyDamage < 0)
            {
                monster.health = 0;
                currentStamina = currentStamina - 30;
                return monster.health;
            }
            else
            {
                monster.health = monster.health - heavyDamage;
                currentStamina = currentStamina - 30;
                return heavyDamage;
            }
        }

    }
}
