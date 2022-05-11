using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_banker
{
    class Mastercard : Card
    {
        int[] prefix = new int[] { 51, 52, 53, 54, 55 };

        public Mastercard(string cardHolderName, long cardBankNumber) : base(cardHolderName, cardBankNumber)
        {
            GenerateCardNumber(prefix);
            cardType = "Mastercard";
        }
    }
}
