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
            ComputerDrawCard();
            ComputerDrawCard();
            ComputerDrawCard();
            ComputerDrawCard();
        }

        Card[] CardDeck = new Card[30];
        Card[] ComputerCardDeck = new Card[30];
        Card[] PlayerHand = new Card[10];
        Card[] ComputerHand = new Card[10];
        Random num = new Random();

        public void RandomizeCards(int i)
        {
            int a = num.Next(1, 11);
            int b = num.Next(1, 11);
            DetermineMana(a, b, i);
        }

        public void ComputerRandomizeCards(int i)
        {
            int a = num.Next(1, 11);
            int b = num.Next(1, 11);
            ComputerDetermineMana(a, b, i);
        }

        public void ComputerDetermineMana(int a, int b, int i)
        {
            int x = a + b;
            string strName = Enum.GetName(typeof(CardName), i);

            if (x < 5)
            {
                ComputerCardDeck[i] = new Card(strName, a, b, 1);
            }
            else if (x > 4 && x < 9)
            {
                ComputerCardDeck[i] = new Card(strName, a, b, 2);
            }
            else if (x > 8 && x < 13)
            {
                ComputerCardDeck[i] = new Card(strName, a, b, 3);
            }
            else if (x > 12 && x < 17)
            {
                ComputerCardDeck[i] = new Card(strName, a, b, 4);
            }
            else if (x > 16 && x < 21)
            {
                ComputerCardDeck[i] = new Card(strName, a, b, 5);
            }
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
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Flag == 0)
                    {
                        if (PlayerHand[i].Name == "" && CardDeck[RandomNum].Name != "")
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
                            ShowCards(i);
                            Flag = 1;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("You have a full hand of cards. You must reduce your hand in order to draw another card.");
            }
        }
        public void ComputerDrawCard()
        {
            int Flag = 0;
            int RandomNum = num.Next(1, 31);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Flag == 0)
                    {
                        if (ComputerHand[i].Name == "" && ComputerCardDeck[RandomNum].Name != "")
                        {
                            ComputerHand[i].Name = ComputerCardDeck[RandomNum].Name;
                            ComputerHand[i].Attack = ComputerCardDeck[RandomNum].Attack;
                            ComputerHand[i].Health = ComputerCardDeck[RandomNum].Health;
                            ComputerHand[i].Mana = ComputerCardDeck[RandomNum].Mana;
                            ComputerCardDeck[RandomNum].Name = "";
                            btn1Comp.Text = ComputerHand[0].Name + "\n" + "Attack: " + ComputerHand[0].Attack + "\n" + "Health: " + ComputerHand[0].Health + "\n" + "Mana: " + ComputerHand[0].Mana;
                            btn2Comp.Text = ComputerHand[1].Name + "\n" + "Attack: " + ComputerHand[1].Attack + "\n" + "Health: " + ComputerHand[1].Health + "\n" + "Mana: " + ComputerHand[1].Mana;
                            btn3Comp.Text = ComputerHand[2].Name + "\n" + "Attack: " + ComputerHand[2].Attack + "\n" + "Health: " + ComputerHand[2].Health + "\n" + "Mana: " + ComputerHand[2].Mana;
                            btn4Comp.Text = ComputerHand[3].Name + "\n" + "Attack: " + ComputerHand[3].Attack + "\n" + "Health: " + ComputerHand[3].Health + "\n" + "Mana: " + ComputerHand[3].Mana;
                            btn5Comp.Text = ComputerHand[4].Name + "\n" + "Attack: " + ComputerHand[4].Attack + "\n" + "Health: " + ComputerHand[4].Health + "\n" + "Mana: " + ComputerHand[4].Mana;
                            btn6Comp.Text = ComputerHand[5].Name + "\n" + "Attack: " + ComputerHand[5].Attack + "\n" + "Health: " + ComputerHand[5].Health + "\n" + "Mana: " + ComputerHand[5].Mana;
                            btn7Comp.Text = ComputerHand[6].Name + "\n" + "Attack: " + ComputerHand[6].Attack + "\n" + "Health: " + ComputerHand[6].Health + "\n" + "Mana: " + ComputerHand[6].Mana;
                            btn8Comp.Text = ComputerHand[7].Name + "\n" + "Attack: " + ComputerHand[7].Attack + "\n" + "Health: " + ComputerHand[7].Health + "\n" + "Mana: " + ComputerHand[7].Mana;
                            btn9Comp.Text = ComputerHand[8].Name + "\n" + "Attack: " + ComputerHand[8].Attack + "\n" + "Health: " + ComputerHand[8].Health + "\n" + "Mana: " + ComputerHand[8].Mana;
                            btn10Comp.Text = ComputerHand[9].Name + "\n" + "Attack: " + ComputerHand[9].Attack + "\n" + "Health: " + ComputerHand[9].Health + "\n" + "Mana: " + ComputerHand[9].Mana;
                            ComputerShowCards(i);
                            Flag = 1;
                        }
                    }
                }
            }
            catch
            {
               
            }
        }

        public void ShowCards(int i)
        {
            if(i == 0)
            {
                btnUser1Hand.Visible = true;
            }
            else if(i == 1)
            {
                btnUser2Hand.Visible = true;
            }
            else if (i == 2)
            {
                btnUser3Hand.Visible = true;
            }
            else if (i == 3)
            {
                button4.Visible = true;
            }
            else if (i == 4)
            {
                btnUser5Hand.Visible = true;
            }
            else if (i == 5)
            {
                btnUser6Hand.Visible = true;
            }
            else if (i == 6)
            {
                btnUser7Hand.Visible = true;
            }
            else if (i == 7)
            {
                btnUser8Hand.Visible = true;
            }
            else if (i == 8)
            {
                btnUser9Hand.Visible = true;
            }
            else if (i == 9)
            {
                btnUser10Hand.Visible = true;
            }
        }

        public void ComputerShowCards(int i)
        {
            if (i == 0)
            {
                btn1Comp.Visible = true;
            }
            else if (i == 1)
            {
                btn2Comp.Visible = true;
            }
            else if (i == 2)
            {
                btn3Comp.Visible = true;
            }
            else if (i == 3)
            {
                btn4Comp.Visible = true;
            }
            else if (i == 4)
            {
                btn5Comp.Visible = true;
            }
            else if (i == 5)
            {
                btn6Comp.Visible = true;
            }
            else if (i == 6)
            {
                btn7Comp.Visible = true;
            }
            else if (i == 7)
            {
                btn8Comp.Visible = true;
            }
            else if (i == 8)
            {
                btn9Comp.Visible = true;
            }
            else if (i == 9)
            {
                btn10Comp.Visible = true;
            }
        }

        public void DisableSlotCards()
        {
            if(btn1Slot.Text == "")
            {
                btn1Slot.Enabled = false;
            }
            if(btn2Slot.Text == "")
            {
                btn2Slot.Enabled = false;
            }
            if (btn3Slot.Text == "")
            {
                btn3Slot.Enabled = false;
            }
            if (btn4Slot.Text == "")
            {
                btn4Slot.Enabled = false;
            }
            if (btn5Slot.Text == "")
            {
                btn5Slot.Enabled = false;
            }
            if (btn6Slot.Text == "")
            {
                btn6Slot.Enabled = false;
            }
            if (btn7Slot.Text == "")
            {
                btn7Slot.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[3].Name;
            HoldingCard.Attack = PlayerHand[3].Attack;
            HoldingCard.Health = PlayerHand[3].Health;
            HoldingCard.Mana = PlayerHand[3].Mana;
            PlayerHand[3].Name = "";
            PlayerHand[3].Attack = 0;
            PlayerHand[3].Health = 0;
            PlayerHand[3].Mana = 0;
            button4.Text = PlayerHand[3].Name + "\n" + "Attack: " + PlayerHand[3].Attack + "\n" + "Health: " + PlayerHand[3].Health + "\n" + "Mana: " + PlayerHand[3].Mana;
            button4.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            DrawCard();
        }

        public void EnableSlots()
        {
            btn1Slot.Enabled = true;
            btn2Slot.Enabled = true;
            btn3Slot.Enabled = true;
            btn4Slot.Enabled = true;
            btn5Slot.Enabled = true;
            btn6Slot.Enabled = true;
            btn7Slot.Enabled = true;
        }

        Card HoldingCard = new Card("", 0, 0, 0);

        private void btnUser1Hand_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[0].Name;
            HoldingCard.Attack = PlayerHand[0].Attack;
            HoldingCard.Health = PlayerHand[0].Health;
            HoldingCard.Mana = PlayerHand[0].Mana;
            PlayerHand[0].Name = "";
            PlayerHand[0].Attack = 0;
            PlayerHand[0].Health = 0;
            PlayerHand[0].Mana = 0;
            btnUser1Hand.Text = PlayerHand[0].Name + "\n" + "Attack: " + PlayerHand[0].Attack + "\n" + "Health: " + PlayerHand[0].Health + "\n" + "Mana: " + PlayerHand[0].Mana;
            btnUser1Hand.Visible = false;
        }

        private void btnUser2Hand_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[1].Name;
            HoldingCard.Attack = PlayerHand[1].Attack;
            HoldingCard.Health = PlayerHand[1].Health;
            HoldingCard.Mana = PlayerHand[1].Mana;
            PlayerHand[1].Name = "";
            PlayerHand[1].Attack = 0;
            PlayerHand[1].Health = 0;
            PlayerHand[1].Mana = 0;
            btnUser2Hand.Text = PlayerHand[1].Name + "\n" + "Attack: " + PlayerHand[1].Attack + "\n" + "Health: " + PlayerHand[1].Health + "\n" + "Mana: " + PlayerHand[1].Mana;
            btnUser2Hand.Visible = false;
        }

        private void btnUser3Hand_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[2].Name;
            HoldingCard.Attack = PlayerHand[2].Attack;
            HoldingCard.Health = PlayerHand[2].Health;
            HoldingCard.Mana = PlayerHand[2].Mana;
            PlayerHand[2].Name = "";
            PlayerHand[2].Attack = 0;
            PlayerHand[2].Health = 0;
            PlayerHand[2].Mana = 0;
            btnUser3Hand.Text = PlayerHand[2].Name + "\n" + "Attack: " + PlayerHand[2].Attack + "\n" + "Health: " + PlayerHand[2].Health + "\n" + "Mana: " + PlayerHand[2].Mana;
            btnUser3Hand.Visible = false;
        }

        private void btnUser5Hand_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[4].Name;
            HoldingCard.Attack = PlayerHand[4].Attack;
            HoldingCard.Health = PlayerHand[4].Health;
            HoldingCard.Mana = PlayerHand[4].Mana;
            PlayerHand[4].Name = "";
            PlayerHand[4].Attack = 0;
            PlayerHand[4].Health = 0;
            PlayerHand[4].Mana = 0;
            btnUser5Hand.Text = PlayerHand[4].Name + "\n" + "Attack: " + PlayerHand[4].Attack + "\n" + "Health: " + PlayerHand[4].Health + "\n" + "Mana: " + PlayerHand[4].Mana;
            btnUser5Hand.Visible = false;
        }

        private void btnUser6Hand_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[5].Name;
            HoldingCard.Attack = PlayerHand[5].Attack;
            HoldingCard.Health = PlayerHand[5].Health;
            HoldingCard.Mana = PlayerHand[5].Mana;
            PlayerHand[5].Name = "";
            PlayerHand[5].Attack = 0;
            PlayerHand[5].Health = 0;
            PlayerHand[5].Mana = 0;
            btnUser6Hand.Text = PlayerHand[5].Name + "\n" + "Attack: " + PlayerHand[5].Attack + "\n" + "Health: " + PlayerHand[5].Health + "\n" + "Mana: " + PlayerHand[5].Mana;
            btnUser6Hand.Visible = false;
        }

        private void btnUser7Hand_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[6].Name;
            HoldingCard.Attack = PlayerHand[6].Attack;
            HoldingCard.Health = PlayerHand[6].Health;
            HoldingCard.Mana = PlayerHand[6].Mana;
            PlayerHand[6].Name = "";
            PlayerHand[6].Attack = 0;
            PlayerHand[6].Health = 0;
            PlayerHand[6].Mana = 0;
            btnUser7Hand.Text = PlayerHand[6].Name + "\n" + "Attack: " + PlayerHand[6].Attack + "\n" + "Health: " + PlayerHand[6].Health + "\n" + "Mana: " + PlayerHand[6].Mana;
            btnUser7Hand.Visible = false;
        }

        private void btnUser8Hand_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[7].Name;
            HoldingCard.Attack = PlayerHand[7].Attack;
            HoldingCard.Health = PlayerHand[7].Health;
            HoldingCard.Mana = PlayerHand[7].Mana;
            PlayerHand[7].Name = "";
            PlayerHand[7].Attack = 0;
            PlayerHand[7].Health = 0;
            PlayerHand[7].Mana = 0;
            btnUser8Hand.Text = PlayerHand[7].Name + "\n" + "Attack: " + PlayerHand[7].Attack + "\n" + "Health: " + PlayerHand[7].Health + "\n" + "Mana: " + PlayerHand[7].Mana;
            btnUser8Hand.Visible = false;
        }

        private void btnUser9Hand_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[8].Name;
            HoldingCard.Attack = PlayerHand[8].Attack;
            HoldingCard.Health = PlayerHand[8].Health;
            HoldingCard.Mana = PlayerHand[8].Mana;
            PlayerHand[8].Name = "";
            PlayerHand[8].Attack = 0;
            PlayerHand[8].Health = 0;
            PlayerHand[8].Mana = 0;
            btnUser9Hand.Text = PlayerHand[8].Name + "\n" + "Attack: " + PlayerHand[8].Attack + "\n" + "Health: " + PlayerHand[8].Health + "\n" + "Mana: " + PlayerHand[8].Mana;
            btnUser9Hand.Visible = false;
        }

        private void btnUser10Hand_Click(object sender, EventArgs e)
        {
            EnableSlots();
            HoldingCard.Name = PlayerHand[9].Name;
            HoldingCard.Attack = PlayerHand[9].Attack;
            HoldingCard.Health = PlayerHand[9].Health;
            HoldingCard.Mana = PlayerHand[9].Mana;
            PlayerHand[9].Name = "";
            PlayerHand[9].Attack = 0;
            PlayerHand[9].Health = 0;
            PlayerHand[9].Mana = 0;
            btnUser10Hand.Text = PlayerHand[9].Name + "\n" + "Attack: " + PlayerHand[9].Attack + "\n" + "Health: " + PlayerHand[9].Health + "\n" + "Mana: " + PlayerHand[9].Mana;
            btnUser10Hand.Visible = false;
        }

        Card[] BattleCards = new Card[7];
        

        private void btn1Slot_Click(object sender, EventArgs e)
        {
            BattleCards[0] = new Card(HoldingCard.Name, HoldingCard.Attack, HoldingCard.Health, HoldingCard.Mana);
            btn1Slot.Text = HoldingCard.Name + "\n" + "Attack: " + HoldingCard.Attack + "\n" + "Health: " + HoldingCard.Health + "\n" + "Mana: " + HoldingCard.Mana;
            DisableSlotCards();
        }

        private void btn2Slot_Click(object sender, EventArgs e)
        {
            BattleCards[1] = new Card(HoldingCard.Name, HoldingCard.Attack, HoldingCard.Health, HoldingCard.Mana);
            btn2Slot.Text = HoldingCard.Name + "\n" + "Attack: " + HoldingCard.Attack + "\n" + "Health: " + HoldingCard.Health + "\n" + "Mana: " + HoldingCard.Mana;
            DisableSlotCards();
        }

        private void btn3Slot_Click(object sender, EventArgs e)
        {
            BattleCards[2] = new Card(HoldingCard.Name, HoldingCard.Attack, HoldingCard.Health, HoldingCard.Mana);
            btn3Slot.Text = HoldingCard.Name + "\n" + "Attack: " + HoldingCard.Attack + "\n" + "Health: " + HoldingCard.Health + "\n" + "Mana: " + HoldingCard.Mana;
            DisableSlotCards();
        }

        private void btn4Slot_Click(object sender, EventArgs e)
        {
            BattleCards[3] = new Card(HoldingCard.Name, HoldingCard.Attack, HoldingCard.Health, HoldingCard.Mana);
            btn4Slot.Text = HoldingCard.Name + "\n" + "Attack: " + HoldingCard.Attack + "\n" + "Health: " + HoldingCard.Health + "\n" + "Mana: " + HoldingCard.Mana;
            DisableSlotCards();
        }

        private void btn5Slot_Click(object sender, EventArgs e)
        {
            BattleCards[4] = new Card(HoldingCard.Name, HoldingCard.Attack, HoldingCard.Health, HoldingCard.Mana);
            btn5Slot.Text = HoldingCard.Name + "\n" + "Attack: " + HoldingCard.Attack + "\n" + "Health: " + HoldingCard.Health + "\n" + "Mana: " + HoldingCard.Mana;
            DisableSlotCards();
        }

        private void btn6Slot_Click(object sender, EventArgs e)
        {
            BattleCards[5] = new Card(HoldingCard.Name, HoldingCard.Attack, HoldingCard.Health, HoldingCard.Mana);
            btn6Slot.Text = HoldingCard.Name + "\n" + "Attack: " + HoldingCard.Attack + "\n" + "Health: " + HoldingCard.Health + "\n" + "Mana: " + HoldingCard.Mana;
            DisableSlotCards();
        }

        private void btn7Slot_Click(object sender, EventArgs e)
        {
            BattleCards[6] = new Card(HoldingCard.Name, HoldingCard.Attack, HoldingCard.Health, HoldingCard.Mana);
            btn7Slot.Text = HoldingCard.Name + "\n" + "Attack: " + HoldingCard.Attack + "\n" + "Health: " + HoldingCard.Health + "\n" + "Mana: " + HoldingCard.Mana;
            DisableSlotCards();
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
