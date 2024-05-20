using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WarCardGame
{
    public partial class WarForm : Form
    {
        
        StartForm.Card[] deck = new StartForm.Card[52];

        public WarForm(StartForm.Card[] deck)
        {
            InitializeComponent();
            this.deck = deck;
        }
        
        private void formLoad(object sender, EventArgs e)
        {
            dealHand();
            refreshLabel();
            lblComputerCardAmt.Visible = true;
            lblPlayerCardAmt.Visible = true;
        }

        List<StartForm.Card> playerHand = new List<StartForm.Card>();
        List<StartForm.Card> computerHand = new List<StartForm.Card>();

        private void btnDraw_Click(object sender, EventArgs e)
        {
            StartForm.Card playerCard, computerCard;

            playerCard = playerHand[0];
            computerCard = computerHand[0];

            lbxTable.Items.Add("Player Drew " + playerCard.ReturnCardString());
            lbxTable.Items.Add("Computer Drew " + computerCard.ReturnCardString());
            lbxTable.Items.Add("");

            if (playerCard.value == 1 || playerCard.value > computerCard.value && computerCard.value != 1)
            {
                lbxTable.Items.Add("Player Won");

                playerHand.Add(computerCard);
                computerHand.Remove(computerHand.First());
                playerHand.Remove(playerHand.First());
                playerHand.Add(playerCard);
                lbxTable.Items.Add("");
            }
            else if (playerCard.value != computerCard.value)
            {
                lbxTable.Items.Add("Computer Won");

                computerHand.Add(playerCard);
                playerHand.Remove(playerHand.First());
                computerHand.Remove(computerHand.First());
                computerHand.Add(computerCard);
                lbxTable.Items.Add("");
            }
            else
            {
                playerHand.Add(playerHand[0]);
                playerHand.RemoveAt(0);

                computerHand.Add(computerHand[0]);
                computerHand.RemoveAt(0);

                WAR();
            }

            if (playerHand.Count <= 0)
            {
                MessageBox.Show("You ran out of cards \nComputer Wins!");
                btnDraw.Enabled = false;
            }
            else if (computerHand.Count <= 0)
            {
                MessageBox.Show("Computer ran out of cards \nPlayer Wins!");
                btnDraw.Enabled = false;
            }

            refreshLabel();
        }

        private void WAR() //Function starts when the player and computer draw a card with the same value
        {
            StartForm.Card[] tempPlayer = new StartForm.Card[3];
            StartForm.Card[] tempComputer = new StartForm.Card[3];
            int playerVal = 0, computerVal = 0, loopIter = 1, count = 0;
            string playerLine = "Player Drew " , computerLine = "Computer Drew ";
            bool continueLoop = true;

            lbxTable.Items.Add("WAR!!!!!");
            lbxTable.Items.Add("");

            while (continueLoop)
            {
                for (count = (3 * loopIter) - 3; count < 3 * loopIter; count++) //fills and array with the cards that will be drawn
                {
                    if (playerHand.Count < 3 * loopIter)
                    {
                        MessageBox.Show("You ran out of cards, Cannot go to war \nComputer Wins!");
                        btnDraw.Enabled = false;
                        Close();
                    }
                    else if (computerHand.Count < 3 * loopIter)
                    {
                        MessageBox.Show("Computer ran out of cards, Cannot go to war \nPlayer Wins!");
                        btnDraw.Enabled = false;
                        Close();
                    }
                    tempPlayer[count] = playerHand[count];
                    tempComputer[count] = computerHand[count];
                }

                foreach (StartForm.Card item in tempPlayer) //Displays cards
                {
                    playerLine += ", " + item.ReturnCardString();
                    playerVal = item.value;
                }

                foreach (StartForm.Card item in tempComputer) //Displays cards
                {
                    computerLine += ", " + item.ReturnCardString();
                    computerVal = item.value;
                }

                lbxTable.Items.Add(playerLine);
                lbxTable.Items.Add(computerLine);

                if (playerVal > computerVal || computerVal > playerVal) //Cheks if the user drew the same card again and if the loop should continue
                {
                    continueLoop = false;
                }
                else
                {
                    loopIter++;
                    Array.Resize(ref tempPlayer, 3 * loopIter);
                    Array.Resize(ref tempComputer, 3 * loopIter);
                    

                    lbxTable.Items.Add("WAR!!!!! X " + loopIter.ToString());
                    lbxTable.Items.Add("");
                    playerLine = "Player Drew ";
                    computerLine = "Computer Drew ";
                }
            }

            if (playerVal > computerVal && computerVal != 1 || playerVal == 1) //checks who won the war
            {
                foreach (StartForm.Card item in tempComputer)
                {
                    playerHand.Add(item);
                    computerHand.Remove(item);
                }
                lbxTable.Items.Add("Player won with " + tempPlayer[tempPlayer.Length - 1].ReturnCardString());
            }
            else
            {
                foreach (StartForm.Card item in tempPlayer)
                {
                    computerHand.Add(item);
                    playerHand.Remove(item);
                }
                lbxTable.Items.Add("Computer won with " + tempComputer[tempComputer.Length - 1].ReturnCardString());
            }

            Array.Resize(ref tempPlayer, 3 );
            Array.Resize(ref tempComputer, 3);
            lbxTable.Items.Add("");
            refreshLabel();
        }

        private void refreshLabel()
        {
            lblPlayerCardAmt.Text = "Player Card Amount: " + playerHand.Count;
            lblComputerCardAmt.Text = "Computer Card Amount " + computerHand.Count;
            lbxTable.SelectedIndex = lbxTable.Items.Count - 1;
            lbxTable.SelectedIndex = -1;
        }

        public void dealHand() //Evenly Distributes the cards between the computer and player
        {
            Random rng = new Random();

            for(int i = 0; i < 52; i++)
            {
                if (i % 2 == 0)
                {
                    playerHand.Add(deck[i]);
                }
                else
                {
                    computerHand.Add(deck[i]);
                }
            }

            playerHand.OrderBy(_ => rng.Next()).ToList();
            computerHand.OrderBy(_ => rng.Next()).ToList();
        }

        
    }
}
