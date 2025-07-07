using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Part1
{
    public class BankAccount
    {

        public string ownerName { get; }
        public double accountNumber;


         int checkBalance(int ID, string password)
        {
            if (ID == 123 && password == "k13")
                return balance;
            else
                return -1;

        }

       //adding buisness role to name creation
        public void SetOwnerName(string name)
        {

            if (!string.IsNullOrEmpty(name) && name.Count()>8)
            {

            }

        }

        public BankAccount(string name, double number)
        { 
         ownerName = name;
         accountNumber = number;

        }

        public BankAccount(string name)       
        {
           ownerName=name;
        }

        public BankAccount(double number)
        {
            accountNumber = number;
        }

        public BankAccount() { }


        public BankAccount(BankAccount b)
        {
          ownerName = b.ownerName;
            accountNumber = b.accountNumber;
        
        }

        int balance = 1000;

        public double withdraw(int amount)
        {
            if(amount < balance)
            { 
            
                balance -= amount;
                logTransaction("withdraw succeeded");
                return balance;

            }
            else 
            {
                logTransaction("withdraw failed");
                return -1;
            }

        }


        void logTransaction(string message)
        {
            Console.Write(message);
        }


    }
}
