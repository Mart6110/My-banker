using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    public abstract class CreditCard: Card
    {
        protected double Credit { get; set; }
        public CreditCard(string name, string cardNumber, string accountNumber, double credit):base(name, cardNumber, accountNumber)
        {
            Credit = credit;
        }


    }
}
