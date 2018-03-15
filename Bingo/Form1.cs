/*
 * Alexandra Hart 
 * 2/7/2018
 * Form Class:
 * This class deals will all of what the user sees. It deals with all of the user input and building of the bingo board. 
 * It also contains the event handlers for the form, text fields, labels, buttons, and panel
*/

using Bingo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bingo
{
    public partial class FrmMainForm : Form
    {
        RNG random = new RNG();
        UsedNumbers usedNumbers = new UsedNumbers();
        InternalBoard interalBoard = new InternalBoard();
        Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];
        Player player = new Player();

        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;
        int bingoCount;
        int selectedNumber;
        int nextCalledNumber;
        int countofCalledNumbers;
        char nextChar;
        String bingoLetters = "BINGO";
        //iniializes components
        public FrmMainForm()
        {
            InitializeComponent();
        }
        //initalizes different form elements when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {

            this.Height = 175;

            txtEnterName.Text = "";
            txtYourNumber.Text = "";
            lblRuleTitle.Enabled = false;
            lblRuleOne.Enabled = false;
            lblRuleTwo.Enabled = false;
            lblRuleThree.Enabled = false;
            lblYourNumber.Enabled = false;
            txtYourNumber.Enabled = false;
            btnDontHave.Enabled = false;
            lblYourBingoCard.Enabled = false;
            pnlBingoCard.Enabled = false;
            btnYes.Enabled = false;

            lblRuleTitle.Visible = false;
            lblRuleOne.Visible = false;
            lblRuleTwo.Visible = false;
            lblRuleThree.Visible = false;
            lblYourNumber.Visible = false;
            txtYourNumber.Visible = false;
            btnDontHave.Visible = false;
            lblYourBingoCard.Visible = false;
            pnlBingoCard.Visible = false;
        }
        //enables form elements, calls playthegame, and calls createcard
        private void btnYes_Click(object sender, EventArgs e)
        {
            bool validateName = player.validateName(txtEnterName.Text);
            if (validateName == true)
            {
                player.setPlayerName(txtEnterName.Text);
                this.Height = 910;
                playTheGame();
                createCard();
                lblRuleTitle.Enabled = true;
                lblRuleOne.Enabled = true;
                lblRuleTwo.Enabled = true;
                lblRuleThree.Enabled = true;
                lblYourNumber.Enabled = true;
                txtYourNumber.Enabled = true;
                btnDontHave.Enabled = true;
                lblYourBingoCard.Enabled = true;
                pnlBingoCard.Enabled = true;

                lblRuleTitle.Visible = true;
                lblRuleOne.Visible = true;
                lblRuleTwo.Visible = true;
                lblRuleThree.Visible = true;
                lblYourNumber.Visible = true;
                txtYourNumber.Visible = true;
                btnDontHave.Visible = true;
                lblYourBingoCard.Visible = true;
                pnlBingoCard.Visible = true;
            }
            else
            {
                MessageBox.Show("Must Enter Name");
            }
        }
        //closes program
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //calls play the game
        private void btnDontHave_Click(object sender, EventArgs e)
        {
            playTheGame();
        }
        //enables the button once user has entered a value
        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {
            btnYes.Enabled = true;
        }
        //records what the users clicked on, changes the cell to orange, calls is winner, and calls play the game
        private void Button_Click(object sender, EventArgs e)
        {
            bingoCount = 1;
            string test = ((Button)sender).Name;
            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);
            if (selectedNumber == nextCalledNumber)
            {
                newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                interalBoard.recordCalledNumber(rowID, colID);
                Global.selectedNumbersListObj.setUsedNumber(selectedNumber);
                bingoCount = isWinner(rowID, colID);
                if ((bingoCount > 0))
                {
                    string playername = player.getPlayerName();
                    MessageBox.Show("You are a Winner " + playername  + "!" , "Winner Found!");
                    Close();
                }

                playTheGame();
            }
            else
            {
                MessageBox.Show("Called number does not match the one in the box you selected."
                          + "Try again!", "Numbers Do Not Match");
            }
        }
        //generates the next number 
        public void playTheGame()
        {
            if (countofCalledNumbers < MAXBINGONUMBER - 1)
            {
                countofCalledNumbers++;
                nextCalledNumber = random.getNextUniqueRandomValue(1, MAXBINGONUMBER);
                usedNumbers.setUsedNumber(nextCalledNumber);
                if (nextCalledNumber < 16)
                {
                    nextChar = 'B';
                }
                else if (nextCalledNumber > 15 && nextCalledNumber < 31)
                {
                    nextChar = 'I';
                }
                else if (nextCalledNumber > 30 && nextCalledNumber < 46)
                {
                    nextChar = 'N';
                }
                else if (nextCalledNumber > 45 && nextCalledNumber < 61)
                {
                    nextChar = 'G';
                }
                else
                {
                    nextChar = 'O';
                }
                string NextVal = Convert.ToString(nextChar) + Convert.ToString(nextCalledNumber);
                txtYourNumber.Text = NextVal;
            }
            else
            {
                usedNumbers.setUsedNumber(0);
                MessageBox.Show("All bingo numbers called. \n you must have missed one or more ");
                Close();
            }
        }
        //creates the buttons and lays them out for the bingo card
        private void createCard()
        {

            Size size = new Size(75, 75);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = random.getRandomValue(bingoLetters[col]).ToString();
                    }
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    newButton[row, col].Click += new EventHandler(Button_Click);

                    pnlBingoCard.Controls.Add(newButton[row, col]);

                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                }

                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            }
            y += barWidth - 1;
            DrawColumnLabels();
            Global.selectedNumbersListObj.reset();
        }
        //draws the column labels
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlBingoCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        }
        //draws the horizontal bars
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlBingoCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        }
        //draws the vertical bars
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlBingoCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }
        //converts a char to an int
        public int convertCharToInt(char c)
        {
            int num = Convert.ToInt32(c);
            return num-48;
        }
        //calls checkForBingo
        public int isWinner(int rowID, int ColID)
        {
            return interalBoard.checkForBingo();
        }
    }
}