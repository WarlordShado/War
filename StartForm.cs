using System;
using System.Windows.Forms;

namespace WarCardGame
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        const int numPerType = 13;

        public struct Card //Stores info on the card
        {
            public string type;
            public string num;
            public int value;

            public string ReturnCardString(){ return num + " of " + type; } //Returns a string to show the user the card type
        }

        public Card[] deck = new Card[52];

        private void btnStart_Click(object sender, EventArgs e) //Starts a game of War
        {
            shuffleArr(ref deck);
            WarForm frm = new WarForm(deck);
            frm.ShowDialog();
        }
        
        private void StartBlackJack(object sender, EventArgs e) //Starts a game of Blackjack
        {
            shuffleArr(ref deck);
            BlackJackForm frm = new BlackJackForm(deck);
            frm.ShowDialog();
        }
        private void FormLoad(object sender, EventArgs e) //Shows the user the deck when the program starts
        {
            lbxCards.Items.Clear();

            fillDeck(ref deck);
            shuffleArr(ref deck);

            foreach (Card item in deck)
            {
                lbxCards.Items.Add(item.ReturnCardString());
            }
        }

        public void shuffleArr(ref Card[] arr) //Shuffles the Deck
        {
            Random rng = new Random();

            int length = arr.Length;

            while (length > 1)
            {
                int randPlace = rng.Next(length--);
                Card temp = arr[length];
                arr[length] = arr[randPlace];
                arr[randPlace] = temp;
            }
        }

        private void fillDeck(ref Card[] deck) //Fills the deck
        {
            for (int typeI = 0; typeI < 4; typeI++)
            {
                for (int i  = 1; i <= numPerType; i++)
                {
                    int deckspot = (numPerType * typeI) + i - 1;

                    if (typeI == 0)
                    {
                        deck[deckspot].type = "Hearts"; 
                    }
                    else if (typeI == 1)
                    {
                        deck[deckspot].type = "Diamonds";
                    }
                    else if (typeI == 2)
                    {
                        
                        deck[deckspot].type = "Spades";
                    }
                    else if(typeI == 3)
                    {
                        deck[deckspot].type = "Clubs";
                    }

                    deck[deckspot].num = getType(i);
                    deck[deckspot].value = i;
                }
            }
            
        }

        private string getType(int num) //Returns the type of card depending on the number
        {
            if (num == 1)
            {
                return "Ace";
            }
            else if (num == 11)
            {
                return "Jack";
            }
            else if (num == 12)
            {
                return "Queen";
            }
            else if (num == 13)
            {
                return "King";
            }
            else
            {
                return num.ToString();
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            shuffleArr(ref deck);
            lbxCards.Items.Clear();
            foreach (Card item in deck)
            {
                lbxCards.Items.Add(item.ReturnCardString());
            }
        }
    }
}
