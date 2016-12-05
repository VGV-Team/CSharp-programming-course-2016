using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int stevilka;
            Int32.TryParse(s, out stevilka);



            Random rand = new Random();


            Entity hero = new Entity();
            hero.name = "Kekec";
            hero.HP = 100;
            hero.strength = rand.Next(50, 80);
            

            Entity monster1 = new Entity();
            monster1.name = "Bedanc";
            monster1.HP = 150;
            monster1.strength = rand.Next(50, 100);

            Entity monster2 = new Entity();
            monster2.name = "Pehta";
            monster2.HP = 50;
            monster2.strength = rand.Next(10, 60);

            Console.WriteLine(hero.name + " " + hero.HP + " " + hero.strength);
            Console.WriteLine(monster1.name + " " + monster1.HP + " " + monster1.strength);
            Console.WriteLine(monster2.name + " " + monster2.HP + " " + monster2.strength);

            bool gameOver = false;
            while (!gameOver)
            {
                if (monster1.isAlive()) hero.attack(monster1);
                if (monster2.isAlive()) hero.attack(monster2);

                if (monster1.isAlive()) monster1.attack(hero);
                if (monster2.isAlive()) monster2.attack(hero);

                if (!hero.isAlive())
                {
                    Console.WriteLine("Katastrofa, pojdi jest špinačo.");
                    gameOver = true;
                }
                else if (!monster1.isAlive() && !monster2.isAlive())
                {
                    Console.WriteLine("Bravo, pognal si ga v kozji rog!");
                    gameOver = true;
                }

                hero.heal();
            }


            //staraKoda();

            
            Console.ReadKey();
        }

        static void staraKoda()
        {
            Hero hero = new Hero();
            hero.name = "Kekec";
            hero.strength = 75;
            hero.HP = 100;

            Monster monster1 = new Monster();
            monster1.name = "Bedanc";
            monster1.HP = 150;
            monster1.strength = 25;

            Monster monster2 = new Monster();
            monster2.name = "Pehta";
            monster2.HP = 50;
            monster2.strength = 10;

            bool gameOver = false;
            while (!gameOver)
            {
                if (monster1.isAlive()) hero.attack(monster1);
                if (monster2.isAlive()) hero.attack(monster2);

                if (monster1.isAlive()) monster1.attack(hero);
                if (monster2.isAlive()) monster2.attack(hero);

                if (!hero.isAlive())
                {
                    Console.WriteLine("Katastrofa, pojdi jest špinačo.");
                    gameOver = true;
                }
                else if (!monster1.isAlive() && !monster2.isAlive())
                {
                    Console.WriteLine("Bravo, pognal si ga v kozji rog!");
                    gameOver = true;
                }
            }

            /*
            Console.WriteLine(hero.name + " napada "+monster1.name);
            hero.attack(monster1);
            hero.attack(monster1);

            Console.WriteLine(hero.name + " napada " + monster2.name);
            hero.attack(monster2);
            */
        }
    }
}
