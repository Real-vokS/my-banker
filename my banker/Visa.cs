using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_banker
{
    class Visa : Card
    {
        int[] prefix = new int[] { 4 };


        public Visa(string cardHolderName, long cardBankNumber) : base(cardHolderName, cardBankNumber)
        {
            GenerateCardNumber(prefix);
            cardType = "Visa";
        }

        
    }
}
