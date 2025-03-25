using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class BankAccount
    {
        private decimal _balance;
        public decimal Balance { get; }
        private int _AccountNumber;
        public int AccountNumber
        {
            get
            { return _AccountNumber; }
        }
        public string Ownername { get; set; }

        public BankAccount(int AccountNumber, string customername, int balance)
        {
            this._AccountNumber = AccountNumber;
            this.Ownername = customername;
            this.Balance = balance;

        }
        public void Deposit(decimal depositamount)
        {
            if (depositamount > 0)
            {
                _balance += depositamount;
                Console.WriteLine($"{depositamount} meblege elave olundu ");
            }
            else
            {
                Console.WriteLine(" mebleg menfi ola bilmez");
            }
        }
        public void WithDraw(decimal withdrawamount)
        {
            if (_balance > withdrawamount)
            {
                _balance -= withdrawamount;
                Console.WriteLine($"{withdrawamount} balansdan cixarildi");
            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"balansiniz {_balance} , adiniz {Ownername} , nomreniz {AccountNumber}");
        }
        public void TransferFunds(BankAccount recipient, decimal amount)
        {
            recipient.Deposit(amount);
            Console.WriteLine($"{recipient}e {amount} azn kocuruldu");
        }
    }
}
