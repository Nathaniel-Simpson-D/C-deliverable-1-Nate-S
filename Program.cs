using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace labe1Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, welcome to the currency converter.");
            System.Console.WriteLine("Please insert your USD amount (please do not use the $).");
            decimal initUsd = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("Please insert your kr amount(just the value please).");
            decimal initKr = Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("Please insert your Baht amount(just the value please).");
            decimal initThia = Convert.ToDecimal(Console.ReadLine());

            decimal convKr = initKr * .11m;
            decimal convThia = (initThia * 0.033m);
            decimal usdTotal = convKr + convThia + initUsd;

            System.Console.Write("The grand total in usd is $");
            System.Console.WriteLine(usdTotal.ToString("F2", CultureInfo.InvariantCulture));

            if (initUsd < convThia && initUsd < convKr)
            {
                System.Console.Write("The lowest value is the usd, $");
                System.Console.WriteLine(initUsd.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (convThia < initUsd && convThia < convKr)
            {
                System.Console.Write("The lowest value is the Baht, in usd $");
                System.Console.WriteLine(convThia.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (convKr < initUsd && convKr < convThia)
            {
                System.Console.Write("The lowest value is the kr, in usd $");
                System.Console.WriteLine(convKr.ToString("F2", CultureInfo.InvariantCulture));
            }
            else { System.Console.WriteLine("All the values are equal."); }

                if (initUsd > convThia && initUsd > convKr)
                 {
                     System.Console.Write("The highest value is the usd, $");
                     System.Console.WriteLine(initUsd.ToString("F2", CultureInfo.InvariantCulture));
                 }
                else if (convThia > initUsd && convThia > convKr)
                 {
                System.Console.Write("The highest value is the Baht, in usd $");
                System.Console.WriteLine(convThia.ToString("F2", CultureInfo.InvariantCulture));
                 }
                 else if (convKr > initUsd && convKr > convThia)
                 {
                System.Console.Write("The highest value is the kr, in usd $");
                System.Console.WriteLine(convKr.ToString("F2", CultureInfo.InvariantCulture));
                 }
                  else { System.Console.WriteLine("Therefor there is no Highest or Lowest."); }

            System.Console.WriteLine("Would you like the Total value converted to another supported currency (Y/N)?");

            string otherCurr= "x";
            otherCurr = Console.ReadLine();

            decimal krTotal = usdTotal / .11m; 
            decimal ThiaTotal = usdTotal / .033m;
            decimal yenTotal = usdTotal / 0.0092m;


            if ("Y" == otherCurr || "y" == otherCurr || "Yes" == otherCurr)  

           
            {

                System.Console.WriteLine("Please press 1 for kr, 2 for Baht, 3 forYen, and 4 for all.");

                int outChoice = Convert.ToInt32(Console.ReadLine());
                switch ( outChoice)
                {
                    case 1:
                        System.Console.Write(krTotal.ToString("F2", CultureInfo.InvariantCulture));
                        System.Console.WriteLine(" kr");
                        break;

                    case 2:
                        System.Console.Write(ThiaTotal.ToString("F2", CultureInfo.InvariantCulture));
                        System.Console.WriteLine(" Baht");
                        break;

                    case 3:
                        System.Console.Write(yenTotal.ToString("F0", CultureInfo.InvariantCulture));
                        System.Console.WriteLine(" Yen");
                        break;

                    default:
                        System.Console.Write(krTotal.ToString("F2", CultureInfo.InvariantCulture));
                        System.Console.WriteLine(" kr");
                        System.Console.Write(ThiaTotal.ToString("F2", CultureInfo.InvariantCulture));
                        System.Console.WriteLine(" Baht");
                        System.Console.Write(yenTotal.ToString("F0", CultureInfo.InvariantCulture));
                        System.Console.WriteLine(" Yen");
                        break;
                }
               
            }
               

            System.Console.WriteLine("Have a good Day.");

        }

    }
}
