using My_banker.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    public abstract class Card: ICustomer, IAccountNumber
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public int[] AccountNumber { get; set; } = new int[10];
        public Card(string name, string regNumber)
        {
            Name = name;
            RegNumber = regNumber;
            AccountNumber = new int[10];

            // Fill up AccountNumber with random numbers between 0 and 9
            Random rand = new Random();
            for (int i = 0; i < AccountNumber.Length; i++)
            {
                AccountNumber[i] = rand.Next(10);
            }
        }
    }
}
