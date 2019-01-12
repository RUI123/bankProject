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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //create 8 bank accounts for users
        private static List <BankAccount> accounts =new List<BankAccount>()
        {   
            new BankAccount("11111111","22222222",500m),
            new BankAccount("22222222","11111111",500m),
            new BankAccount("33333333","44444444",500m),
            new BankAccount("44444444","33333333",500m),

            new BankAccount("55555555","66666666",500m),
            new BankAccount("66666666","55555555",500m),
            new BankAccount("77777777","88888888",500m),
            new BankAccount("88888888","77777777",500m)
        };

        //create 4 user objects and 1 administractive account
        public List <UserProfile> users=new List<UserProfile>
        {
            //administractive account
            new UserProfile("BANKER12","1234"),
            //user accounts
            new UserProfile("A1111111","1111",accounts[0],accounts[1]),
            new UserProfile("A3333333","3333",accounts[2],accounts[3]),
            new UserProfile("A5555555","5555",accounts[4],accounts[5]),
            new UserProfile("A7777777","7777",accounts[6],accounts[7])
        };

        //create second form-main menu
        private Form2 mainMenu = new Form2();
        //initialize a variable to count number of log in
        private int count = 0;

        //load the first form
        private void Form1_Load(object sender, EventArgs e)
        {
            //once first form load, add a mouse click event handle to 
            //radio button exit in form main menu
            mainMenu.rbtExit.MouseClick += new MouseEventHandler((o, a) =>
            {
                //display a dialog box to ask user either go back to log
                //in form or not

                string info = "Are you sure to exit your user account?";

                DialogResult btDialog = MessageBox.Show(info,
                    "Exit Account", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                //set cancel action to two buttons in dialog

                if (btDialog == DialogResult.Yes)
                {
                    mainMenu.Visible = false;
                    this.Visible = true;
                }
            });
        }

        //function to test if the data in first form is valid
        private bool IsValid()
        {
            return
                Validator.IsFill(txtAccount)&&
                Validator.IsFill(txtPassword)&&

                Validator.IsUserName(txtAccount)&&
                Validator.IsDigit(txtPassword)&&
                Validator.IsAllowedNumberCharacters(txtPassword,4);

        }

        //event handle for log in button
        private void btLog_MouseClick(object sender, MouseEventArgs e)
        {
            //test if it's a bank officer's account
            if (txtAccount.Text.ToUpper() == users[0].UserName &&
                txtPassword.Text == users[0].Pin)
            {
                txtAccount.Text = "";
                txtPassword.Text = "";
                count = 0;
                this.Close();
            }
            else
            {
                //test if it's reaching 3 attempts
                if (count < 3)
                {
                    //test if it's valid data
                    if (IsValid() && IsExist())
                    {
                        //invisible first form 
                        this.Visible = false;

                        //clear entries 
                        txtAccount.Text = "";
                        txtPassword.Text = "";
                        count = 0;
                        txtAccount.Focus();

                        //and show second form
                        mainMenu.Show();

                    }
                    else
                    {
                        //count number of attempts
                        count++;
                    }
                }

                //test if it's reaching 3 attempts
                if (count == 3)
                {
                    //frozen form, not further inpus
                    btLog.Visible = false;
                    lbPin.Text = "PLEASE SEE A BANK OFFICER\n" +
                        "NO FURTHER LOGIN ATTEMPTS ALLOWED.";
                    txtPassword.Visible = false;
                    txtPassword.Text = "";
                    txtAccount.Text = "";
                }
            }

        }

        private void txtAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //test if box for password is invisible, if it is, then
            //click enter, if it's a bank officer's account
            //,then release password option
            if (txtPassword.Visible == false &&
                e.KeyChar == (char)Keys.Enter)
            {
                if (txtAccount.Text.ToUpper() == users[0].UserName)
                {
                    lbPin.Text = "Password";
                    txtPassword.Visible = true;
                    txtPassword.Focus();
                    txtAccount.Enabled = false;

                }
                else
                {
                    txtAccount.Text = "";
                    txtAccount.Focus();
                }
            }

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            //test if log in button is invisible, if it is, then
            //click enter, if it's a bank officer's account and password
            //,then release the form.  user can enter their accounts
            if (btLog.Visible == false &&
                e.KeyChar == (char)Keys.Enter)
            {
                //test if it's a right password
                if (txtPassword.Text == users[0].Pin)
                {
                    btLog.Visible = true;
                    lbPin.Visible = true;
                    count = 0;
                    txtPassword.Text = "";
                    txtAccount.Text = "";
                }
                else
                {
                    txtPassword.Text = "";
                    txtAccount.Text = "";
                    lbPin.Text = "PLEASE SEE A BANK OFFICER\n" +
                        "NO FURTHER LOGIN ATTEMPTS ALLOWED.";
                    txtPassword.Visible = false;
                }
                txtAccount.Enabled = true;
                txtAccount.Focus();

            }
        }

        //function to test if the account is exist
        public bool IsExist()
        {
            //test if it's one of the  bank users' names
            foreach (UserProfile user in users)
                if (users[0].UserName != txtAccount.Text.ToUpper() &&
                    user.UserName == txtAccount.Text.ToUpper())
                    if (user.Pin == txtPassword.Text)
                    {
                        mainMenu.setUserProfile(user);
                        return true;
                    }
                    else
                    {
                        //display error message
                        MessageBox.Show("Password does not match.", "Entry Error");
                        txtPassword.Focus();
                        return false;
                    }

            //display error message
            MessageBox.Show("User does not exist.", "Entry Error");
            txtAccount.Focus();
            return false;
        }

        //create a dialog box when window is going to close
        //ask for ending program or not
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string info = "Are you sure to end program?";

            DialogResult btDialog = MessageBox.Show(info,
                "Customer", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if (btDialog == DialogResult.No)
                e.Cancel = true;
        }
    }
}
