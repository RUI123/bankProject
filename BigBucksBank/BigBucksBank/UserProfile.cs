using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{

    //create a class of object for a user's 
    //entirely information in the bank
    public class UserProfile
    {
        //define variable as user id
        private string userName;
        //define variable as user's password
        private string pin;
        //define a bank account object as a checking account
        private BankAccount check;
        //define a bank account object as a saving account
        private BankAccount save;

        public UserProfile()
        {
        }

        //constructor defines an object of user profile
        public UserProfile(string userName, string pin, BankAccount check,BankAccount save)
        {
            this.UserName = userName;
            this.Pin = pin;
            this.Check = check;
            //set the type of checking account
            this.Check.AccountType = true;
            this.Save = save;
            //set the type of saving account
            this.Save.AccountType = false;
        }

        //constructor defines an object of Administrative account
        public UserProfile(string administractiveAccount, string pin)
        {
            this.UserName = administractiveAccount;
            this.Pin = pin;
        }

        //set and getter methods for member variables
        public string UserName
        {
            get 
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
        public string Pin
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
            }
        }
        
        public BankAccount Check
        {
            get
            {
                return check;
            }
            set
            {
                check = value;
            }
        }
        public BankAccount Save
        {
            get
            {
                return save;
            }
            set
            {
                save = value;
            }
        }

        //function to test if the account is a checking account
        //or saving account
        public bool IsCheckingAccount(string account)
        {
            if (this.Check.SourceAccount == account)
                return this.Check.AccountType;
            else
                return this.Save.AccountType;
        }

        //function to calculate transaction of transfer funds
        public void transferFunds(string account,decimal money) 
        {
            //test if it's a saving account or checking account
            if (this.Save.SourceAccount == account)
            {
                this.Save.toWithdrawal(money);
                this.Check.toDeposit(money);
              
            }
            else
            {
                this.Check.toWithdrawal(money);
                this.Save.toDeposit(money);
            }
        }
        
        //function to calculate transaction of withdrawal
        public void withdrawal(string account, decimal money)
        {
            if (this.Save.SourceAccount == account)
                this.Save.toWithdrawal(money);
            else
                this.Check.toWithdrawal(money);
        }

        //function to calculate transaction of deposit
        public void deposit(string account, decimal money)
        {
            if (this.Save.SourceAccount == account)
                this.Save.toDeposit(money);
            else
                this.Check.toDeposit(money);
        }

        //function to return the balance of specific account
        public decimal checkBalance(string account)
        {
            if (this.Save.SourceAccount == account)
                return this.Save.Money;
            else
                return this.Check.Money;
        }
        
        
    }

 
}
