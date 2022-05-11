using System;

namespace my_banker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Visa visa = new Visa("Carl Hansen", 432432432432423523);
            Console.WriteLine(visa.CardNumber);

            Mastercard mc = new Mastercard("Carl Hansen",432432432432432 );
            Console.WriteLine(mc.CardNumber);

            VisaElectron ve = new VisaElectron("Carl Hansen", 3432432432432);
            Console.WriteLine(ve.CardNumber);

            Maestro mo = new Maestro("CArl handsen", 203209320);
            Console.WriteLine(mo.CardExpireDate);


        }
    }
}
