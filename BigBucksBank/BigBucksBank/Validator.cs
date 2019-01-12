using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBucksBank
{
    //create a class to validate all entries
    public static class Validator
    {
        //variable to  set the title of message box
        private static string warning = "Entry Error";

        //set and get methods for the variable
        public static string Warning 
        {
            get 
            {
                return warning;
            }
            set 
            { 
                warning = value;
            }
        }

        //function to test if the textbox empty
        public static bool IsFill(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        //function to test if data in textbox is 
        //a decimal number with tow decimal places
        public static bool IsDecimal(TextBox textBox)
        {
            decimal num = 0m;
            //test if it's decimal number
            if (Decimal.TryParse(textBox.Text, out num))
            {
                num = Decimal.Parse(textBox.Text);
                //test if it's two decimals
                if ((num * 100) - (int)(num * 100) > 0)
                {
                    MessageBox.Show(textBox.Tag + " must have less or "+
                        "equal two decimal places.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
                return true;
            }
            else
            {
                //error message
                MessageBox.Show(textBox.Tag+ " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        //function to test if the data is a digital number
        public static bool IsDigit(TextBox textBox)
        {
            
            foreach(char character in textBox.Text)
            {
                if (!Char.IsDigit(character))
                {  
                    MessageBox.Show(textBox.Tag + " must be an Number.", Warning);
                    textBox.Focus();
                    return false;
                }
            }
            
            return true;   
            
        }

        //function to test if the data have specific 
        //number of characters
        public static bool IsAllowedNumberCharacters(TextBox textBox, int numOfChar)
        {
            if (textBox.Text.Length == numOfChar)
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be "+numOfChar+" characters.", Warning);
                textBox.Focus();
                return false;
            }
        }

        //function to test if the data is made by letters and numbers
        public static bool IsLetterDigit(TextBox textBox)
        {
            int num =0;
            //test if it's made by letters or numbers
            foreach (char character in textBox.Text)
            {
                if (!Char.IsLetterOrDigit(character)){
                    MessageBox.Show(textBox.Tag + " must be made by letters and numbers.", Warning);
                    textBox.Focus();
                    return false;
                }
            }

            //test if it's all made by numbers
            if (Int32.TryParse(textBox.Text, out num))
            {
                MessageBox.Show(textBox.Tag + " must be made by letters and numbers.", Warning);
                textBox.Focus();
                return false;
            }

            //test if it's all made by letters
            foreach (char character in textBox.Text)
                if (!Char.IsLetter(character))
                    return true;

             MessageBox.Show(textBox.Tag + " must be made by letters and numbers.", Warning);
             textBox.Focus();
             return false;
        }

        //function to test if data follows conditions 
        //(8 characters, made by letters and number,
        //first char is letter) for a user name
        public static bool IsUserName(TextBox textBox)
        {
            //test if first character is  a letter
            if (!Char.IsLetter(textBox.Text[0]))
            {
                MessageBox.Show(textBox.Tag + " must begin with a letter.", Warning);
                textBox.Focus();
                return false;
            }
            else
                return
                    IsLetterDigit(textBox) &&
                    IsAllowedNumberCharacters(textBox,8);
        }

        //function to test if the money is not negative
        public static bool IsNonnegative(TextBox textBox)
        {
            if (Decimal.Parse(textBox.Text) < 0)
            {
                MessageBox.Show("Amount of money must be non-negative.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
        
        //function test if it's an account under this user
        public static bool IsSourceAccount(TextBox textBox,UserProfile user)
        {
            if (!(user.Check.SourceAccount==textBox.Text||
                user.Save.SourceAccount==textBox.Text))
            {
                MessageBox.Show("Invalid account Number, Please enter a " +
                    "Account Number which belongs to you.", "Wrong Account Number",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        //function to test if it's a right target account
        //to the source account
        public static bool IsTargetAccount(TextBox textBox1,TextBox textBox2, UserProfile user)
        {
            Warning = "Wrong Target Account";
            //test if it's the checking account
            if (user.Check.SourceAccount == textBox1.Text)
            {
                if (user.Check.TargetAccount == textBox2.Text)
                    return true;
                else
                {
                    //show error message
                    MessageBox.Show("Invalid account Number, Please enter " +
                "another account number as Target Account.", Warning,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return false;
                }
            }
            
            //test if it's a saving account
            else if (user.Save.SourceAccount == textBox1.Text)
            {
                if (user.Save.TargetAccount == textBox2.Text)
                    return true;
                else
                {
                    //show error message
                    MessageBox.Show("Invalid account Number, Please enter " +
                "another account number as Target Account.", Warning,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return false;
                }
            }
            //show error message 
            MessageBox.Show("Invalid account Number, Please enter " +
                "another account number as Target Account.", Warning,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox1.Focus();
            return false;
        }

        //function to test if bank account have enough money for user 
        //taking out
        public static bool IsWithinRange(TextBox textbox, decimal money)
        {

            decimal transaction = Convert.ToDecimal(textbox.Text);

            if (transaction > money)
            {
                MessageBox.Show("There is not enough money for " +
                    "current transaction in your account", "Out of Range",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        //function to test if user enter a right money formate
        //ex. one dollar is going to enter as "1.00".
        public static bool IsMoneyFormate(TextBox textbox) 
        {
            if (textbox.Text == Convert.ToDecimal(textbox.Text).ToString("F2"))
                return true;
            else
            {
                MessageBox.Show("Wrong Formate, Please enter money"+
                    " formate as,\n ex. 1.00" , "Money Formate");
                return false;
            }

        }
    }
}
