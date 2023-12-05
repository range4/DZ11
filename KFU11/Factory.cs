using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFU11
{
    internal class Factory
    {
        private Dictionary<uint, Bank> accountTable;

        public Factory()
        {
            accountTable = new Dictionary<uint, Bank>();
        }

        public uint GetNextID()
        {
            return Bank.id_counter;
        }

        public uint CreateAccount(AccountType accountType, decimal Balance)
        {
            Bank account = new Bank(accountType, Balance);
            uint id = account.GetAccountID();
            accountTable.Add(id, account);
            return id;
        }

        public void CloseAccount(uint id)
        {
            if (accountTable.ContainsKey(id))
            {
                accountTable.Remove(id);
                Console.WriteLine("Счёт " + id + " закрыт");
            }
            else
            {
                Console.WriteLine("Счёт " + id + " не найден");
            }
        }
    }
}
