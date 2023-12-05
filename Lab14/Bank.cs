using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lab14;

namespace KFU11
{
    [DeveloperInfo("Vladislav N", "05.12.20023")]
    public enum AccountType
    {
        Current,
        Savings
    }



    public class Bank
    {
        protected bool flag_dispose = false;
        private object HashCode;


        public static uint id_counter = 1;
        public static uint Id_counter
        {
            get
            {
                return id_counter;
            }
            set
            {
                id_counter = value;
            }
        }
        private uint id;
        public uint Id
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }
        private string holder;
        public string Holder
        {
            get
            {
                return holder;
            }
            protected set
            {
                holder = value;
            }
        }
        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                balance = value;
            }
        }
        private AccountType accounttype;
        public AccountType accountType
        {
            get
            {
                return accounttype;
            }
            protected set
            {
                accounttype = value;
            }
        }
        private List<Transaction> transactions = new List<Transaction>();
        public List<Transaction> Transactions
        {
            get
            {
                return transactions;
            }
            set
            {
                transactions = value;
            }
        }
        public Transaction this[int index]
        {
            get
            {
                return transactions[index];
            }
        }



        public void CreateUniqeID()
        {
            id_counter++;
        }

        public Bank()
        {
            CreateUniqeID();
            id = id_counter;
        }
        public Bank(AccountType accountType)
        {
            CreateUniqeID();
            id = id_counter;
            this.accountType = accountType;
        }

        public Bank(decimal Balance)
        {
            CreateUniqeID();
            id = id_counter;
            this.Balance = Balance;
        }

        public Bank(AccountType accountType, decimal Balance)
        {
            CreateUniqeID();
            id = id_counter;
            this.accountType = accountType;
            this.Balance = Balance;
        }

        public Bank(AccountType accountType, decimal Balance, string holder)
        {
            CreateUniqeID();
            id = id_counter;
            this.accountType = accountType;
            this.Balance = Balance;
            this.holder = holder;
        }



        public void WithDraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Не достаточно средств для снятия введенной суммы :(");
            }
            else
            {
                Transaction transaction = new Transaction(amount);
                transactions.Add(transaction);
                Balance -= amount;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 10)
            {
                Transaction transaction = new Transaction(amount);
                transactions.Add(transaction);
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Можно переводить только от 10 рублей\n");
            }
        }

        public void Transfer(Bank account, decimal amount, Bank account1)
        {
            if (amount > account.Balance)
            {
                Console.WriteLine("Не достаточно средств для перевода введенной суммы :(");
            }
            else
            {
                Transaction transaction = new Transaction(amount);
                transactions.Add(transaction);
                account.Balance -= amount;
                account1.Balance += amount;
                Console.WriteLine($"Совершен перевод {amount} рублей на счет {account1.id}, ваш баланс {account.Balance}, если перевод совершили не вы или возникла ошибка, обратитесь в поддержку по номеру горячей линии +79375975337");
            }


        }
        public void GetBalance()
        {
            Console.WriteLine($"Ваш баланс - {Balance}");
        }

        public void Dispose()
        {
            if (!flag_dispose)
            {
                foreach (Transaction trans in transactions)
                {
                    File.WriteAllText("transactions.txt", trans.Print());
                }
                transactions.Clear();
                flag_dispose = true;

                GC.SuppressFinalize(this);
            }
        }


        public uint GetAccountID()
        {
            return id;
        }

        public AccountType GetAccountType()
        {
            return accountType;
        }
        public override string ToString()
        {
            return $"AccountNumber - {id}, Balance - {Balance}, AccountType - {accountType}";
        }

        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"AccountNumber - {id}, Balance - {Balance}, AccountType - {accountType}");
        }
    }
}