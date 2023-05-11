using My_banker.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    public class VisaElectron: Expire, IMonthlyMax
    {
        public string Prefix { get; }
        public int[] CardNumber { get; }
        public int RegNumber { get; }
        public int[] KontoNumber { get; }
        public long MonthlyMax { get; }

        public VisaElectron(string name) : base(name)
        {
            Prefix = GeneratePrefix();
            CardNumber = GenerateRandomCardNumber();
            RegNumber = 3520;
            KontoNumber = GenerateRandomKontoNumber(10);
            MonthlyMax = 10000;
        }

        private string GeneratePrefix()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);

            switch (randomNumber)
            {
                case 1:
                    return "4026";
                case 2:
                    return "4175";
                case 3:
                    return "4508";
                case 4:
                    return "4844";
                case 5:
                    return "4913";
                case 6:
                    return "4917";
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
