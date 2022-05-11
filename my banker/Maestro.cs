using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_banker
{
    class Maestro : Card, IExpireDate
    {
        int[] prefix = new int[] { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
        public Maestro(string cardHolderName, long cardBankNumber) : base(cardHolderName, cardBankNumber)
        {
            GenerateCardNumber(prefix);
            cardType = "Maestro";

        }

        void IExpireDate.ExpireDate()
        {
            DateTime expireDate = DateTime.Now;

            expireDate.AddYears(5);
            expireDate.AddMonths(8);

            cardExpireDate = expireDate;
        }

    }
}
