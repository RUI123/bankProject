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
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
        }

        //set action for ok button
        private void btOk_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        //set validation 
        public bool isValid( UserProfile userProfile)
        {
            //set validation for transfer funds
            if (txtTarget.Visible == true)
                return
                    Validator.IsFill(txtAccount) &&
                    Validator.IsFill(txtAmount) &&
                    Validator.IsFill(txtTarget) &&


                    Validator.IsDigit(txtAccount) &&
                    Validator.IsAllowedNumberCharacters(txtAccount, 8) &&
                    Validator.IsSourceAccount(txtAccount, userProfile) &&

                    Validator.IsDecimal(txtAmount) &&
                    Validator.IsNonnegative(txtAmount) &&

                    Validator.IsDigit(txtTarget) &&
                    Validator.IsAllowedNumberCharacters(txtTarget, 8) &&
                    Validator.IsTargetAccount(txtAccount, txtTarget, userProfile) &&

                    Validator.IsMoneyFormate(txtAmount)&&
                    Validator.IsWithinRange(txtAmount, userProfile.
                        checkBalance(txtAccount.Text));

                //set validation for check balance
            else if (lbTitle.Text == "Check Balance")

                return
                    Validator.IsFill(txtAccount) &&

                    Validator.IsDigit(txtAccount) &&
                    Validator.IsAllowedNumberCharacters(txtAccount, 8) &&
                    Validator.IsSourceAccount(txtAccount, userProfile);
                
                //validation for withdrawal
            else if (lbTitle.Text == "Withdrawal")
                return
                    Validator.IsFill(txtAccount) &&
                    Validator.IsFill(txtAmount) &&

                    Validator.IsDigit(txtAccount) &&
                    Validator.IsAllowedNumberCharacters(txtAccount, 8) &&
                    Validator.IsSourceAccount(txtAccount, userProfile) &&

                    Validator.IsDecimal(txtAmount) &&
                    Validator.IsNonnegative(txtAmount) &&

                    Validator.IsMoneyFormate(txtAmount)&&
                    Validator.IsWithinRange(txtAmount, userProfile.
                        checkBalance(txtAccount.Text));
                
                //set validation for deposit
            else
                return
                    Validator.IsFill(txtAccount) &&
                    Validator.IsFill(txtAmount) &&

                    Validator.IsDigit(txtAccount) &&
                    Validator.IsAllowedNumberCharacters(txtAccount, 8) &&
                    Validator.IsSourceAccount(txtAccount, userProfile) &&

                    Validator.IsDecimal(txtAmount) &&
                    Validator.IsNonnegative(txtAmount)&&
                    Validator.IsMoneyFormate(txtAmount);
        }

        private void DialogBox_Load(object sender, EventArgs e)
        {

        }

        //clear all entries and set arrangement as default
        public void clearEntry()
        {
            txtAmount.Enabled = true;
            txtAccount.Enabled = true;
            txtTarget.Visible = false;
            lbTarget.Visible = false;

            lbMoney.Text = "Amount Of Money\n(Formate: ex. 1.00)";

            txtAccount.Text = "";
            txtAmount.Text = "";
            txtTarget.Text = "";

            txtAccount.Focus();
        }
    }
}
