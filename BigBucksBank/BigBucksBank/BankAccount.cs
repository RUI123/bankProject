using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    //create a class for a bank account
    public class BankAccount
    {
        //define a variable as its account number
        private string sourceAccount;
        //variable to define the other account number
        private string targetAccount;
        //define it's a checking account for true, saving for false
        private bool accountType;
        //variable to define money in this account
        private decimal money;

        
        public BankAccount()
        {
        }

        //define a bank object 
        public BankAccount(string sourceAccount, string targetAccount,
            decimal money)
        {
            this.Money = money;
            this.SourceAccount = sourceAccount;
            this.TargetAccount = targetAccount;
            //as default set it as checking account
            this.AccountType = true;
        }
        //set and get methods for each variables
        public string SourceAccount
        {
            get
            {
                return sourceAccount;
            }
            set
            {
                sourceAccount = value;
            }
        }

        public string TargetAccount
        {
            get
            {
                return targetAccount;
            }
            set
            {
                targetAccount = value;
            }
        }

        public decimal Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public bool AccountType
        {
            get
            {
                return accountType;
            }
            set
            {
                accountType=value;
            }
        }

        //function to add money to account
        public void toDeposit(decimal transactionMoney)
        {
            money += transactionMoney;
        }

        //function to take money out of bank account
        public void toWithdrawal(decimal transactionMoney)
        {
            money -= transactionMoney;
        }
        
    }
}
