using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KFU11
{
    public class Transaction
    {
        public readonly DateTime date;

        public readonly decimal Amount;

        public Transaction(decimal amount)
        {
            date = DateTime.Now;
            Amount = amount;
        }

        public string Print()
        {
            return ($"{date} совершена транзакция на {Amount} рублей , для просмотра деталей обратитесь в поддержку");
        }
    }
}