using My_banker.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    public class Mastercard : Expire, ICredit, IMonthlyMax
    {
        public string Prefix { get; }
        public int[] CardNumber { get; }
        public int RegNumber { get; }
        public int[] KontoNumber { get; }
        public long Credit { get; set; }
        public long MonthlyMax { get; }

        public Mastercard(string name) : base(name)
        {
            Prefix = GeneratePrefix();
            CardNumber = GenerateRandomCardNumber();
            RegNumber = 3520;
            KontoNumber = GenerateRandomKontoNumber(10);
            Credit = 40000;
            MonthlyMax = 30000;
        }

        private string GeneratePrefix()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 6);

            switch (randomNumber)
            {
                case 1:
                    return "0051";
                case 2:
                    return "0052";
                case 3:
                    return "0053";
                case 4:
                    return "0054";
                case 5:
                    return "0055";
                default:
                    return "0000";  // Default value if random number is out of range
            }
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
