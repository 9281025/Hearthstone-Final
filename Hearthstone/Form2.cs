using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearthstone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Hero Hero = new Hero();

        private void btnDruid_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Power: +1 Attack this turn & +1 Armor");
        }

        private void btnHunter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Power: Deal 2 damage to the enemy Hero");
        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Power: Deal 1 damage");
        }

        private void btnPaladin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Power: Summon an 1/1 Silver Hand Recruit");
        }

        private void btnPriest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Power: Restore 2 health");
        }

        private void btnRogue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Power: Equip an 1/2 Dagger");
        }

        private void btnShaman_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Power: Deal 2 damage");
        }

        private void btnWarlock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Power: Draw a card and take 2 damage");
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hero Power: Gain 2 armor");
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            Hero.Name = "Malfurion Stormrage";
            Hero.HeroPower = "Druid";
            lblSelectedFighter.Text = "Malfurion Stormrage";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Hero.Name = "Rexxar";
            Hero.HeroPower = "Hunter";
            lblSelectedFighter.Text = "Rexxar";
        }

        private void btnJP_Click(object sender, EventArgs e)
        {
            Hero.Name = "Jaina Proudmoore";
            Hero.HeroPower = "Mage";
            lblSelectedFighter.Text = "Jaina Proudmoore";
        }

        private void btnUL_Click(object sender, EventArgs e)
        {
            Hero.Name = "Uther Lighbringer";
            Hero.HeroPower = "Paladin";
            lblSelectedFighter.Text = "Uther Lighbringer";
        }

        private void btnAW_Click(object sender, EventArgs e)
        {
            Hero.Name = "Anduin Wrynn";
            Hero.HeroPower = "Priest";
            lblSelectedFighter.Text = "Anduin Wrynn";
        }

        private void btnVS_Click(object sender, EventArgs e)
        {
            Hero.Name = "Valeera Sanguinar";
            Hero.HeroPower = "Rogue";
            lblSelectedFighter.Text = "Valeera Sanguinar";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            Hero.Name = "Thrall";
            Hero.HeroPower = "Shaman";
            lblSelectedFighter.Text = "Thrall";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            Hero.Name = "Gul'dan";
            Hero.HeroPower = "Warlock";
            lblSelectedFighter.Text = "Gul'dan";
        }

        private void btnGH_Click(object sender, EventArgs e)
        {
            Hero.Name = "Garrosh Hellscream";
            Hero.HeroPower = "Warrior";
            lblSelectedFighter.Text = "Garrosh Hellscream";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }
    }

    public class Hero
    {
        public static string Name { get; set; }
        public static string HeroPower { get; set; }
        public static int Health { get; set; }

        public Hero()
        {
            Name = "";
            HeroPower = "";
            Health = 30;
        }
    }
}
