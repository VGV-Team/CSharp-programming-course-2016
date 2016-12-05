using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Entity hero;
        Entity monster;

        public Form1()
        {
            InitializeComponent();

            hero = new Entity();
            monster = new Entity();

            hero.lightDamage = 100;
        }

        private void bLightAttack_Click(object sender, EventArgs e)
        {
            int damage = hero.LightAttack(monster);

            tbLog.Text += "Hero does " + damage + " to monster and uses " + 30 + " stamina. Monster has " + monster.health + " HP left.\r\n";
            pbEnemyHP.Value = monster.health;
            lStamina.Text = hero.currentStamina + " / " + hero.maxStamina;

            if (hero.health - monster.lightDamage < 0)
            {
                pbHeroHP.Value = 0;
                tbLog.Text += "Monster does " + hero.health + " to hero. Hero has " + hero.health + " HP left.\r\n";

            }
            else
            {
                pbHeroHP.Value -= monster.lightDamage;
                tbLog.Text += "Monster does " + monster.lightDamage + " to hero. Hero has " + hero.health + " HP left.\r\n";
            }
        }

        private void bHeavyAttack_Click(object sender, EventArgs e)
        {
            int damage = hero.HeavyAttack(monster);

            tbLog.Text += "Hero does " + damage + " to monster and uses " + 30 + " stamina. Monster has "+ monster.health +" HP left.\r\n";
            pbEnemyHP.Value = monster.health;
            lStamina.Text = hero.currentStamina + " / " + hero.maxStamina;

            if (hero.health - monster.lightDamage < 0)
            {
                pbHeroHP.Value = 0;
                tbLog.Text += "Monster does " + hero.health + " to hero. Hero has " + hero.health + " HP left.\r\n";

            }
            else
            {
                pbHeroHP.Value -= monster.lightDamage;
                tbLog.Text += "Monster does " + monster.lightDamage + " to hero. Hero has " + hero.health + " HP left.\r\n";
            }
        }
    }
}
