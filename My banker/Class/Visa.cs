using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    public class Visa: CreditCard
    {
        public Visa(string name, string cardNumber, string accountNumber, double credit) : base(name, cardNumber, accountNumber, credit)
        {

        }
        public string GetName()
        {
            return Name;
        }
        public string GetCardNumber()
        {
            return CardNumber;
        }
        public string GetAccountNumber()
        {
            return AccountNumber;
        }


    }
}
