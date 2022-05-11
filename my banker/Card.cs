using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_banker
{
    abstract class Card
    {
        protected string cardType;
        protected string cardHolderName;
        protected long cardNumber;
        protected long cardBankNumber;
        protected DateTime cardExpireDate;

        int cardNumberLength = 16;

        Random rnd = new Random();

        protected Card(string cardHolderName, long cardBankNumber)
        {
            this.cardBankNumber = cardBankNumber;
            this.cardHolderName = cardHolderName;
        }

        protected void GenerateCardNumber(int[] prefix)
        {
            int index = rnd.Next(0, prefix.Length);
            string tempCardNumber;
            foreach (char number in prefix[index].ToString())
            {
                cardNumberLength--;
            }

            tempCardNumber = prefix[index].ToString();

            for(int i = 0; i < cardNumberLength; i++)
            {
                tempCardNumber += rnd.Next(1, 10);
            }

            cardNumber = Convert.ToInt64(tempCardNumber);
        }

        public string CardHolderName
        {
            get => cardHolderName;
        }

        public long CardBankNumber
        {
            get => cardBankNumber;
        }

        public long CardNumber
        {
            get => cardNumber;
        }

        public DateTime CardExpireDate
        {
            get => cardExpireDate;
        }

    }
}
