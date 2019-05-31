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
            for(int g = 0; g < 10; g++)
            {
                PlayerHand[g] = new Card("", 0, 0, 0);
            }
            DrawCard();
            DrawCard();
            DrawCard();
        }

        Card[] CardDeck = new Card[30];
        Card[] PlayerHand = new Card[10];
        Card[] ComputerHand = new Card[10];
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

        public void DrawCard()
        {
            int Flag = 0;
            int RandomNum = num.Next(1, 31);
            for(int i = 0; i < 10; i++)
            {
               if(Flag == 0)
                {
                    if(PlayerHand[i].Name == "" && CardDeck[RandomNum].Name != "")
                    {
                        PlayerHand[i].Name = CardDeck[RandomNum].Name;
                        PlayerHand[i].Attack = CardDeck[RandomNum].Attack;
                        PlayerHand[i].Health = CardDeck[RandomNum].Health;
                        PlayerHand[i].Mana = CardDeck[RandomNum].Mana;
                        CardDeck[RandomNum].Name = "";
                        btnUser1Hand.Text = PlayerHand[0].Name + "\n" + "Attack: " + PlayerHand[0].Attack + "\n" + "Health: " + PlayerHand[0].Health + "\n" + "Mana: " + PlayerHand[0].Mana;
                        btnUser2Hand.Text = PlayerHand[1].Name + "\n" + "Attack: " + PlayerHand[1].Attack + "\n" + "Health: " + PlayerHand[1].Health + "\n" + "Mana: " + PlayerHand[1].Mana;
                        btnUser3Hand.Text = PlayerHand[2].Name + "\n" + "Attack: " + PlayerHand[2].Attack + "\n" + "Health: " + PlayerHand[2].Health + "\n" + "Mana: " + PlayerHand[2].Mana;
                        button4.Text = PlayerHand[3].Name + "\n" + "Attack: " + PlayerHand[3].Attack + "\n" + "Health: " + PlayerHand[3].Health + "\n" + "Mana: " + PlayerHand[3].Mana;
                        btnUser5Hand.Text = PlayerHand[4].Name + "\n" + "Attack: " + PlayerHand[4].Attack + "\n" + "Health: " + PlayerHand[4].Health + "\n" + "Mana: " + PlayerHand[4].Mana;
                        btnUser6Hand.Text = PlayerHand[5].Name + "\n" + "Attack: " + PlayerHand[5].Attack + "\n" + "Health: " + PlayerHand[5].Health + "\n" + "Mana: " + PlayerHand[5].Mana;
                        btnUser7Hand.Text = PlayerHand[6].Name + "\n" + "Attack: " + PlayerHand[6].Attack + "\n" + "Health: " + PlayerHand[6].Health + "\n" + "Mana: " + PlayerHand[6].Mana;
                        btnUser8Hand.Text = PlayerHand[7].Name + "\n" + "Attack: " + PlayerHand[7].Attack + "\n" + "Health: " + PlayerHand[7].Health + "\n" + "Mana: " + PlayerHand[7].Mana;
                        btnUser9Hand.Text = PlayerHand[8].Name + "\n" + "Attack: " + PlayerHand[8].Attack + "\n" + "Health: " + PlayerHand[8].Health + "\n" + "Mana: " + PlayerHand[8].Mana;
                        btnUser10Hand.Text = PlayerHand[9].Name + "\n" + "Attack: " + PlayerHand[9].Attack + "\n" + "Health: " + PlayerHand[9].Health + "\n" + "Mana: " + PlayerHand[9].Mana;
                        Flag = 1;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            DrawCard();
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
