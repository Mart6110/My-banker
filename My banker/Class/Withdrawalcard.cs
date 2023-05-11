using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    class Withdrawalcard: Card
    {
        public string Prefix { get; }
        public int[] CardNumber { get; }
        public int RegNumber { get; }
        public int[] KontoNumber { get; }
        public long Credit { get; set; }
        public long MonthlyMax { get; }

        public Withdrawalcard(string name) : base(name)
        {
            Prefix = "2400";
            CardNumber = GenerateRandomCardNumber();
            RegNumber = 3520;
            KontoNumber = GenerateRandomKontoNumber(10);
        }

        private int[] GenerateRandomCardNumber()
        {
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

