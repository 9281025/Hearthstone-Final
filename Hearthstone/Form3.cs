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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
            {
                RandomizeCards(i);
            }
            string HeroName = Hero.Name;
            int HeroHealth = Hero.Health;
            string HeroPower = Hero.HeroPower;
            btnUserHero.Text = HeroName + "\n" + "\n" + HeroPower;
            lblUserHeroHealth.Text = "Health: " + Convert.ToString(HeroHealth);
            int RandomNum = num.Next(1, 31);
            btnUser1Hand.Text = CardDeck[RandomNum].Name + "\n" + "Attack: " + Convert.ToString(CardDeck[RandomNum].Attack) + "Health: " + Convert.ToString(CardDeck[RandomNum].Health) + "Mana: " + Convert.ToString(CardDeck[RandomNum].Mana);
            int RandomNum1 = num.Next(1, 31);
            btnUser2Hand.Text = CardDeck[RandomNum1].Name + "\n" + "Attack: " + Convert.ToString(CardDeck[RandomNum1].Attack) + "Health: " + Convert.ToString(CardDeck[RandomNum1].Health) + "Mana: " + Convert.ToString(CardDeck[RandomNum1].Mana);
            int RandomNum2 = num.Next(1, 31);
            btnUser3Hand.Text = CardDeck[RandomNum2].Name + "\n" + "Attack: " + Convert.ToString(CardDeck[RandomNum2].Attack) + "Health: " + Convert.ToString(CardDeck[RandomNum2].Health) + "Mana: " + Convert.ToString(CardDeck[RandomNum2].Mana);
        }

        Card[] CardDeck = new Card[30];
        Random num = new Random();

        public void RandomizeCards(int i)
        {
            int a = num.Next(1, 11);
            int b = num.Next(1, 11);
            DetermineMana(a, b, i);
        }
        public void DetermineMana(int a, int b, int i)
        {
            int x = a + b;
            string strName = Enum.GetName(typeof(CardName), i);

            if (x < 5)
            {
                CardDeck[i] = new Card(strName, a, b, 1);
            }
            else if(x > 4 && x < 9)
            {
                CardDeck[i] = new Card(strName, a, b, 2);
            }
            else if (x > 8 && x < 13)
            {
                CardDeck[i] = new Card(strName, a, b, 3);
            }
            else if (x > 12 && x < 17)
            {
                CardDeck[i] = new Card(strName, a, b, 4);
            }
            else if (x > 16 && x < 21)
            {
                CardDeck[i] = new Card(strName, a, b, 5);
            }
        }
        enum CardName { Golemagg = 1, Abomination, Acidmaw, Acolyte, Acornbearer, Alexstrasza, Alleycat, Watcher, Anomalus, Baku, Lynchen, Geddon, Rivendare,
        Sentry, Djinn, Nullifier, Guardian, Racketeer, Hydra, Gunspire, Pixie, Pirate, Corruptor, Cultist, Witch, Raptor, Thalnos, Corsair, Howler, Sniper}

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
    public class Card
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public Card(string name, int attack, int health, int mana)
        {
            Name = name;
            Attack = attack;
            Health = health;
            Mana = mana;
        }
    }
}
