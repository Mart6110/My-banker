using My_banker.Class;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace My_banker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            Visa visa = new Visa("Jens Jensen");
            Mastercard mastercard = new Mastercard("Peter Petersen");
            VisaElectron visaElectron = new VisaElectron("Lone Lonesen");
            Maestro maestro = new Maestro("Ole Olesen");
            Withdrawalcard withdrawalcard = new Withdrawalcard("Lars Larsen");

            // Add cards to the list
            cards.Add(visa);
            cards.Add(mastercard);
            cards.Add(visaElectron);
            cards.Add(maestro);
            cards.Add(withdrawalcard);

            // Loop through each card and print property values
            foreach (Card card in cards)
            {
                Console.WriteLine("Name: " + card.Name);

                Type cardType = card.GetType();
                PropertyInfo[] properties = cardType.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    // Check if the property is CardNumber or KontoNumber
                    if (property.Name == "CardNumber" || property.Name == "KontoNumber")
                    {
                        int[] numbers = (int[])property.GetValue(card);
                        string numbersString = string.Join("", numbers);
                        Console.WriteLine(property.Name + ": " + numbersString);
                    }
                    else
                    {
                        object value = property.GetValue(card);
                        Console.WriteLine(property.Name + ": " + value);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
