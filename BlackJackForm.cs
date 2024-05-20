using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WarCardGame
{
    public partial class BlackJackForm : Form
    {

        List<StartForm.Card> deck = new List<StartForm.Card>();
        public BlackJackForm(StartForm.Card[] deck)
        {
            InitializeComponent();

            foreach (StartForm.Card card in deck) //Adds the cards to the list deck
            {
                this.deck.Add(card);
            }
        }

        int playerTot, computerTot;
        bool lockedIn = false;

        private void btnLockIn_Click(object sender, EventArgs e)
        {
            lockedIn = true;
            game();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            btnLockIn.Enabled = true;
            game();
        }

        private void game()
        {
            if (!lockedIn)
            {
                StartForm.Card card = deck[0];
                lbxTable.Items.Add("You drew a " + card.ReturnCardString());
                playerTot += card.value;
                if (playerTot == 21)
                {
                    MessageBox.Show("You hit 21!! \n You Win");
                    enableBtn(false);
                }
                else if (playerTot > 21)
                {
                    MessageBox.Show("You went over 21, you have lost.");
                    enableBtn(false);
                }
                lbxTable.Items.Add("Current Total: " + playerTot.ToString());
                lbxTable.Items.Add("Click lock in if you are finished.");
                lbxTable.Items.Add("");

                StartForm.Card tempCard = deck[0];
                deck.RemoveAt(0);
                deck.Add(tempCard);
            }
            else
            {
                while (computerTot <= playerTot)
                {
                    StartForm.Card ComputerCard = deck[0];
                    computerTot += ComputerCard.value;

                    lbxTable.Items.Add("Computer drew a " + ComputerCard.ReturnCardString());
                    lbxTable.Items.Add("Computer Total Value: " + computerTot.ToString());
                    lbxTable.Items.Add("");

                    if (computerTot == 21)
                    {
                        MessageBox.Show("Computer hit 21, you have lost.");
                        enableBtn(false);
                    }
                    else if (computerTot > 21)
                    {
                        MessageBox.Show("Computer went over 21, you have won!");
                        enableBtn(false);

                    }
                    else if (computerTot > playerTot)
                    {
                        MessageBox.Show("Computer exceeded you value, you have lost.");
                        enableBtn(false);

                    }
                    
                    StartForm.Card tempCard = deck[0];
                    deck.RemoveAt(0);
                    deck.Add(tempCard);
                }
            }
        }

        private void enableBtn(bool enabled)
        {
            btnDraw.Enabled = enabled;
            btnLockIn.Enabled = enabled;
        }
    }
}
