using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //create an object of the dialog box form
        private DialogBox box = new DialogBox();
        //create an object of user profile
        private static UserProfile newUser = new UserProfile();
        //create an object of third form  as receipt
        private Form3 receipt = new Form3();


        private void Form2_Load(object sender, EventArgs e)
        {
            //once this form is load, set to be a form 
            //with standard arrangement (not choice to 
            //enter target account number)
            box.lbTarget.Visible = false;
            box.txtTarget.Visible = false;

            //once it's load, add a event handle to dialog box form
            //button ok
            box.btOk.MouseClick += new MouseEventHandler((o, a) =>
            {
                //test if entries in dialog box form are validate
                if (box.isValid(newUser))
                {
                    //test if arrangement of dialog is for check balance
                    if (box.lbTitle.Text == "Check Balance")
                    {
                        //test if it's time to return main menu
                        if (!box.txtAccount.Enabled)
                        {
                            this.Visible = true;
                            box.Visible = false;
                            box.clearEntry();
                        }
                        //to show the balance
                        else
                        {
                            box.txtAccount.Enabled = false;
                            box.txtAmount.Text = newUser.
                                checkBalance(box.txtAccount.Text).ToString("C2");
                        }
                    }
                        //doing other transactions
                    else
                    {
                        //calculate result of each transaction
                        calculateTransaction();
                        //show result of each transaction as a receipt
                        writeReceipt();
                        //invisible dialog box and clear all entries
                        box.Visible = false;
                        box.clearEntry();
                        //show the receipt
                        receipt.Show();
                    }
                }


            });

            //once it loads, set a handle for close button in receipt form
            receipt.btClose.MouseClick += new MouseEventHandler((o, a) =>
            {
                this.Visible = true;
            });

        }

        //get a copy of all users' data
        public void setUserProfile( UserProfile user)
        {
            newUser= user;
        }

        //set action for doing deposit, and set the the arrangement of 
        //the dialog form to specific action
        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            
            this.Visible = false;
            box.Visible = true;
            box.lbTitle.Text = "Deposit";
        }

        //set action for doing withdrawal
        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            box.Visible = true;
            box.lbTitle.Text = "Withdrawal";
        }

        //set action for doing check balance
        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            box.Visible = true;
            box.txtAmount.Enabled = false;
            box.lbTitle.Text = "Check Balance";
            box.lbMoney.Text = "Balance";
        }

        //set action for transfering funds
        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            box.Visible = true;
            box.lbTarget.Visible = true;
            box.txtTarget.Visible = true;
            box.lbTitle.Text = "Transfer Funds";

            receipt.lbTarget.Visible = true;
            receipt.txtBalance2.Visible = true;
        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        //function to calculate transaction
        private void calculateTransaction() 
        {
            if (box.lbTitle.Text == "Deposit")
                newUser.deposit(box.txtAccount.Text, 
                    Convert.ToDecimal(box.txtAmount.Text));

            else if (box.lbTitle.Text == "Withdrawal")
                newUser.withdrawal(box.txtAccount.Text,
                    Convert.ToDecimal(box.txtAmount.Text));
            
            else if (box.lbTitle.Text == "Transfer Funds")
            {
                newUser.transferFunds(box.txtAccount.Text,
                    Convert.ToDecimal(box.txtAmount.Text));
            }

        }

        //function to write all fields in a receipt
        private void writeReceipt() 
        {
            receipt.txtId.Text = newUser.UserName;
            receipt.txtDate.Text =DateTime.Today.ToShortDateString();
            receipt.txtAmount.Text = Convert.ToDecimal
                (box.txtAmount.Text).ToString("C2");
            receipt.txtBalance1.Text = newUser.checkBalance
                (box.txtAccount.Text).ToString("C2");
            receipt.lbSource.Text = getShortNum(box.txtAccount.Text);

            string transactionInfo="";
            string transactionType = "";

            if (newUser.IsCheckingAccount(box.txtAccount.Text))
                transactionInfo = "Checking Account ";
            else
                transactionInfo = "Saving Account ";


            if (box.lbTitle.Text == "Deposit")
                transactionType=" DEPOSIT";

            else if (box.lbTitle.Text == "Withdrawal")
                transactionType=" WITHDRAWAL";

            else if (box.lbTitle.Text == "Transfer Funds")
            {
                transactionType = " TRANSFER FUNDS to ";

                if (newUser.IsCheckingAccount(box.txtTarget.Text))
                    transactionType += "Checking Account ";
                else
                    transactionType += "Saving Account ";

                transactionType += getShortNum(box.txtTarget.Text);

                receipt.txtBalance2.Text = newUser.checkBalance
                    (box.txtTarget.Text).ToString("C2");
                receipt.lbTarget.Text = getShortNum(box.txtTarget.Text);
            }

            receipt.txtTransaction1.Text = transactionInfo+
                getShortNum(box.txtAccount.Text)+transactionType;
        }

        //get the last 4 digits of account number
        public string getShortNum(string account)
        {
            return "****" + account.Substring(4, 4);
        }


    }
}
