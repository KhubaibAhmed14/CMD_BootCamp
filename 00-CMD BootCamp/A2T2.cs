using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A2_T2
{
    internal class A2T2
    {

        class BankAccount
            {
            int AccountNumber;
            string AccountHolderName;
            decimal Balance;

            public BankAccount(int accountNumber, string accountHolderName, decimal balance)
            {
                AccountNumber = accountNumber;
                AccountHolderName = accountHolderName;
                Balance = balance;
            }
            public BankAccount() { }

            public decimal getBalance() { return Balance; }
            public int getAccountNumber() { return AccountNumber; }
            public string getAccountHolder() { return AccountHolderName; }
            public void setBalance(decimal balance) { Balance = balance; }
            public void setAccountNumber(int accountNumber) { AccountNumber = accountNumber; }
            public void setAccountHolderName(string accountHolderName) { AccountHolderName=accountHolderName; }

            public virtual void Deposit(decimal amount)
            {
                Balance += amount;
            }

            public virtual void Withdraw(decimal amount)
            {
                Balance -= amount;
            }

            public void DisplayAccountInfo()
            {
                Console.WriteLine($"Account Number: {AccountNumber}");
                Console.WriteLine($"Account Holder: {AccountHolderName}");
                Console.WriteLine($"Balance: {Balance:C}");
            }
        }

        class SavingsAccount : BankAccount
        {
            public decimal InterestRate { get; set; }

            public SavingsAccount(int accountNumber, string accountHolderName, decimal balance, decimal interestRate) :
                base(accountNumber, accountHolderName, balance)
            { 
                InterestRate = interestRate;
            }

            public override void Deposit(decimal amount)
            {
                amount = amount * InterestRate;
                base.Deposit(amount);
            }
        }

        class CheckingAccount : BankAccount
        {
            public override void Withdraw(decimal amount)
            {
                if (getBalance() <= amount)
                {
                    base.Withdraw(amount);
                }
                else Console.WriteLine("Insufficient Balance.");
            }
        }

        class Bank
        {
            List<BankAccount> accounts;
            public Bank()
            {
                this.accounts = new List<BankAccount>();
            }
            public Bank(List<BankAccount> accounts)
            {
                this.accounts = accounts;
            }

            public void AddAccount(BankAccount account)
            {
                this.accounts.Add(account);
            }
            public void DepositToAccount(BankAccount account, decimal amount)
            {
                bool state = false;
                foreach(BankAccount account2 in this.accounts)
                {
                    if(account2 == account) account.Deposit(amount);
                    state = true;
                }
                if (state) { Console.WriteLine($"{account.getAccountNumber()} not found in the Bank."); }
            }

            public void WithdrawFronAccount(BankAccount account, decimal amount)
            {
                bool state = false;
                foreach (BankAccount account2 in this.accounts)
                {
                    if (account2 == account) account.Withdraw(amount);
                    state = true;
                }
                if (state) { Console.WriteLine($"{account.getAccountNumber()} not found in the Bank."); }
            }
        }

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            SavingsAccount savingsAccount = new SavingsAccount(123, "Ali", (decimal)50000.0, (decimal)0.5);

        }
    }
}
