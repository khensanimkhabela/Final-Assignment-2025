




using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assignment_2025
{
    public partial class FinalAssignment : Form
    {
        public FinalAssignment()
        {
            InitializeComponent();
        }

        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        //Declare the constants 
        const double PaymentPerGame = 50;
        const double BonusRate = 0.03;

        //Declare the global variables
        double TotalPayment, AvgScore;
        string PhoneNumber, GameCode;
        int NumOfValidReviewers = 0;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tmsProcess_Click(object sender, EventArgs e)
        {
            //Declare the local variables
            double Payment = 0, BonusAmt = 0, TotalScore = 0;
            int NumGames = 0, GameScore = 0;

            //Convert input 
            PhoneNumber = txtPhoneNumber.Text;

            //Intialise the blnFormInput 
            bool blnFormInput = true;

            // Call the method to validate form input
            blnFormInput = ValidateFormInput(blnFormInput);

            if (blnFormInput == true)
            {
                GameCode = GetGameCode(GameCode);

                while (GameCode != "DONE")
                {
                    bool blnValidCode = true;

                    blnValidCode = ValidateGameCode(GameCode, blnValidCode);

                    if (blnValidCode == true)
                    {
                        GameScore = Convert.ToInt32(GetGameScore(GameScore));

                        bool blnValidScore = true;

                        blnValidScore = ValidateGameScore(GameScore, blnValidScore);

                        if (blnValidScore == true)
                        {
                            NumGames = NumGames + 1;
                            //Payment = NumGames * PaymentPerGame;
                            TotalScore += GameScore;

                        }
                    }

                    GameCode = GetGameCode(GameCode);

                }

                if (NumGames > 0)
                {
                    NumOfValidReviewers += 1;
                }

                Payment = NumGames * PaymentPerGame;

                BonusAmt = CalcBonusAmt(Payment, BonusAmt, NumGames);

                Payment = Payment + BonusAmt;

                AvgScore = TotalScore / NumGames;

                //TotalScore = CalcAveScore(NumGames, TotalScore);

                TotalPayment = TotalPayment + Payment;

                DisplayOutput(Payment, AvgScore, NumOfValidReviewers);
            }
        }


        private bool ValidateFormInput(bool blnFormInput)
        {
            //Validate Phone Number
            if (PhoneNumber == "")
            {
                blnFormInput = false;
                MessageBox.Show("Please Enter A Valid Phone Number");
            }

            //Validate Genre
            if (!rdbAdventure.Checked && !rdbCombat.Checked && !rdbSport.Checked)
            {
                blnFormInput = false;
                MessageBox.Show("Please Select A Genre");
            }

            return blnFormInput;
        }


        private string GetGameCode(string GameCode)
        {
            GameCode = InputBox("Enter Game Code", "Game Code", "");
            return GameCode;
        }


        private bool ValidateGameCode(string GameCode, bool blnValidCode)
        {
            if (rdbSport.Checked)
            {
                if (GameCode != "NFS" && GameCode != "NBA" && GameCode != "FIF")
                {
                    blnValidCode = false;
                    MessageBox.Show("Please Enter A Valid Game Code");
                }
            }
            else if (rdbAdventure.Checked)
            {
                if (GameCode != "MIN" && GameCode != "ROB" && GameCode != "UNC")
                {
                    blnValidCode = false;
                    MessageBox.Show("Please Enter A Valid Game Code");
                }
            }
            else if (rdbCombat.Checked)
            {
                if (GameCode != "COD" && GameCode != "WDS" && GameCode != "FOR")
                {
                    blnValidCode = false;
                    MessageBox.Show("Please Enter A Valid Game Code");
                }
            }


            return blnValidCode;
        }


        private bool ValidateGameScore(int GameScore, bool blnValidScore)
        {
            if (GameScore < 0 || GameScore > 5)
            {
                blnValidScore = false;
                MessageBox.Show("Score must be between 0 and 5");
            }
            return blnValidScore;
        }

        private string GetGameScore(int GameScore)
        {
            GameScore = Convert.ToInt32(InputBox("Enter Game Score", "Game Score", ""));
            return Convert.ToString(GameScore);
        }


        private double CalcBonusAmt(double Payment, double BonusAmt, int NumGames)
        {
            if (chkExperience.Checked && NumGames >= 3)
            {
                BonusAmt = Payment * BonusRate;
            }
            return BonusAmt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tsmClear_Click(object sender, EventArgs e)
        {

        }

        private void tmsExit_Click(object sender, EventArgs e)
        {

        }


        /* private double CalcAveScore(int NumGames, double TotalScore)
         {
             if (NumGames > 0)
             {
                 AvgScore = TotalScore / NumGames;
             }

             else AvgScore = 0;

             return AvgScore;
         }*/

        private void DisplayOutput(double Payment, double AvgScore, int NumOfValidReviewers)
        {
            lblAccPayment.Text = "R" + TotalPayment.ToString("0.00");
            lblPayment.Text = "R" + Payment.ToString("0.00");
            lblAveScore.Text = AvgScore.ToString("0.0");
            lblValidReviewers.Text = NumOfValidReviewers.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
