using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.L2
{
    class OOP
    {
        enum TypeAccount
        {
            vip,
            normal,
            block
        }
        class BankAccount
        {
            private int _balance = 00;
            private int _accountNumber;

            public string AccountNumber { get; set; }
            public int Balance { get; set; }
            public TypeAccount Type { get; set; }

            public BankAccount()
            {
                AccountNumber = Convert.ToString(_Rdm());
                Balance = _balance;
                Type = TypeAccount.block;
            }
            public BankAccount(int balance, TypeAccount type)
            {
                AccountNumber = Convert.ToString(_Rdm());
                Balance = balance;
                Type = type;
            }
            public BankAccount(string nameAcc, int balance, TypeAccount type)
            {
                AccountNumber = nameAcc;
                Balance = balance;
                Type = type;
            }
            public void Print()
            {
                Console.WriteLine($"AN_{AccountNumber},Balance_{Balance},Type_{Type}");
            }
            private int _Rdm()
            {
                Random rnd = new Random();
                _accountNumber = rnd.Next(10000, 20000);
                return _accountNumber;
            }

        }
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("09539", 434267, TypeAccount.vip);
            account.Print();
            BankAccount account1 = new BankAccount();
            account1.Print();
            BankAccount account2 = new BankAccount(35746, TypeAccount.normal);
            account2.Print();
        }

    }
}
