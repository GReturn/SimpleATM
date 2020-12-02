using System;
using System.Windows.Forms;

namespace SimpleATM

    //OBJECTIVES: Login, Accounts, Database, Winforms
{
    public partial class bongATMDashboard : Form
    {
        public bongATMDashboard()
        {
            InitializeComponent();
        }

        double amount, withdrawAmount, depositAmount;

        public string Balance() => "Your current balance is Php " + amount + ". ";
        public double Withdraw() => amount -= withdrawAmount;
        public double Deposit() => amount += depositAmount;

        private void BtnCheckBalance_Click(object sender, EventArgs e)
        {
            DeactivateBtn();
            
            TxtDisplay.Text = Balance(); 
            TxtUI.Text = string.Empty;
        }

        public void BtnWithdraw_Click(object sender, EventArgs e)
        {
            ActivateBtn(); 
            
            AmountWithdraw.Enabled = true; AmountDeposit.Enabled = false;

            TxtDisplay.Text = Balance() + "Please use the buttons to insert the amount you wish to withdraw.";
            TxtUI.Text = "Enter amount: ";             
        }
        public void BtnDeposit_Click(object sender, EventArgs e)
        {
            ActivateBtn(); 
            
            AmountWithdraw.Enabled = false; AmountDeposit.Enabled = true;
           
            TxtDisplay.Text = Balance() + "Please use the buttons to insert the amount you wish to deposit.";
            TxtUI.Text = "Enter amount: ";                  
        }

        // Gets user input text from index 14
        private double GrabInput() => Convert.ToDouble(TxtUI.Text.Substring(14));

        public void AmountWithdraw_Click(object sender, EventArgs e)
        {
            GrabInput();

            withdrawAmount = GrabInput();

            if (withdrawAmount > amount)
            {
                TxtDisplay.Text = "Error! The amount you wanted to withdraw exceeded the amount in your account. " +
                    "Please input a different amount.";
            }
            else
            {
                WithdrawEvent();
            }
        }

        public void AmountDeposit_Click(object sender, EventArgs e)
        {
            GrabInput();

            depositAmount = GrabInput();
            DepositEvent();
        }   

        private void ActivateBtn()
        {
            Btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn0.Enabled = true;
            btnDot.Enabled = true;
            btnBack.Enabled = true;
            btnClear.Enabled = true;
        }
        private void DeactivateBtn()
        {
            Btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn0.Enabled = false;
            btnDot.Enabled = false;
            btnBack.Enabled = false;
            btnClear.Enabled = false;
        }

        public void WithdrawEvent()
        {             
            TxtDisplay.Text = "You have successfully withdrawn Php " + withdrawAmount + ". ";
            TxtUI.Text = "Enter amount: ";
            Withdraw();
        }
        public void DepositEvent()
        {            
            TxtDisplay.Text = "You have successfully deposited Php " + depositAmount + ". ";
            TxtUI.Text = "Enter amount: ";
            Deposit();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
               TxtUI.Text += "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += "2";
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += "3";
            }
        } 
        private void btn4_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += "4";
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += "9";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += "0";
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (String.Compare(TxtUI.Text, "Enter amount: ") < 0)
            {
                TxtUI.Text = TxtUI.Text.Substring(0, TxtUI.Text.Length - 1 + 1);
            }
            else
            {
                TxtUI.Text = TxtUI.Text.Substring(0, TxtUI.Text.Length - 1);
            }
        }
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (TxtUI.Text != null)
            {
                TxtUI.Text += ".";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtUI.Text = "Enter amount: ";
        }
    }
}