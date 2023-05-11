using My_banker.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    public class Visa : Expire, ICredit, IMonthlyMax
    {
        public string Prefix { get; }
        public int[] CardNumber { get; }
        public int RegNumber { get; }
        public int[] KontoNumber { get; }
        public long Credit { get; set; }
        public long MonthlyMax { get; }

        public Visa(string name) : base(name)
        {
            Prefix = "0004";
            CardNumber = GenerateRandomCardNumber();
            RegNumber = 3520;
            KontoNumber = GenerateRandomKontoNumber(10);
            Credit = 20000;
            MonthlyMax = 25000;
        }

        private int[] GenerateRandomCardNumber()
        {
            // Generate an array of random numbers for the card number
            Random random = new Random();
            int[] cardNumber = new int[12];

            for (int i = 0; i < 12; i++)
            {
                cardNumber[i] = random.Next(0, 10);
            }

            return cardNumber;
        }

        private int[] GenerateRandomKontoNumber(int length)
        {
            // Generate an array of random numbers for the Konto number
            Random random = new Random();
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(0, 10);
            }

            return numbers;
        }
    }

}
