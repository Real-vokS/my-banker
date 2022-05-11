using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_banker
{
    class VisaElectron : Card
    {

        int[] prefix = new int[] { 4026, 417500, 4508, 4844, 4913, 4917 };

        public VisaElectron(string cardHolderName, long cardBankNumber) : base(cardHolderName, cardBankNumber)
        {
            GenerateCardNumber(prefix);
            cardType = "Visa Electron";
        }
    }
}
