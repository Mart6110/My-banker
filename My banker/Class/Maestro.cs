using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_banker.Class
{
    class Maestro : Expire
    {
        public string Prefix { get; }
        public int[] CardNumber { get; }
        public int RegNumber { get; }
        public int[] KontoNumber { get; }
        public long MonthlyMax { get; }

        public Maestro(string name) : base(name)
        {
            Prefix = GeneratePrefix();
            CardNumber = GenerateRandomCardNumber();
            RegNumber = 3520;
            KontoNumber = GenerateRandomKontoNumber(10);
        }

        private string GeneratePrefix()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 10);

            switch (randomNumber)
            {
                case 1:
                    return "5018";
                case 2:
                    return "5020";
                case 3:
                    return "5038";
                case 4:
                    return "5893";
                case 5:
                    return "6304";
                case 6:
                    return "6759";
                case 7:
                    return "6761";
                case 8:
                    return "6762";
                case 9:
                    return "6763";
                default:
                    return "0000";  // Default value if random number is out of range
            }
        }

        private int[] GenerateRandomCardNumber()
        {
            Random random = new Random();
            int[] cardNumber = new int[15];

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
