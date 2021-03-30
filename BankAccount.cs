using System;

namespace console_bank_c_
{
    public class BankAccount
    {
        private Client _Client;
        public Client Client
        {
            get { return _Client;  }
            set { _Client = value; }
        }

        private float _Balance;
        public float Balance
        {
            get { return _Balance;  }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be below Zero");
                }
                else
                {
                    _Balance = value;
                }
                
            }
            
        }

        private string _Type;
        public string Type
        {
            get { return _Type; }
            set { _Type = value;  }
        }

        public BankAccount(Client Client, string Type, float Balance = 0)
        {
            this.Client = Client;
            this.Balance = Balance;
            this.Type = Type;
        }

        public float CheckBalance()
        {
            return this.Balance;
        }

        public void Withdraw(float ammount)
        {
            if (Balance - ammount < 0)
            {
                Console.WriteLine("ammount cannot go below zero");
            }
            else
            {
                this.Balance -= ammount;
            }
        }

        public void Deposit(float ammount)
        {
            if (ammount < 0)
            {
                Console.WriteLine("ammount cannot be below Zero");
            }
            else
            {
                this.Balance += ammount;
            }
            
        }
    }
}