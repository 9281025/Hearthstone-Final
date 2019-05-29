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
        }
        Card[] CardDeck = new Card[30];

        public void RandomizeCards(int i)
        {
            Random num = new Random();
            int a = num.Next(1, 11);
            int b = num.Next(1, 11);
            DetermineMana(a, b, i);
        }
        public void DetermineMana(int a, int b, int i)
        {
            int x = a + b;
            if (x < 5)
            {
                CardDeck[i] = new Card("", a, b, 1);
            }
            else if(x > 4 && x < 9)
            {
                CardDeck[i] = new Card("", a, b, 2);
            }
            else if (x > 8 && x < 13)
            {
                CardDeck[i] = new Card("", a, b, 3);
            }
            else if (x > 12 && x < 17)
            {
                CardDeck[i] = new Card("", a, b, 4);
            }
            else if (x > 16 && x < 21)
            {
                CardDeck[i] = new Card("", a, b, 5);
            }
        }
    }
    enum CardDeck { }
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
