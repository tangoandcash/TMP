using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NIPQuest.HelpModule
{
    public static class ValidatorClass
    {
        //// 3 uwzględnione wzorce
        ////7777777777
        static Regex regexTenDigits = new Regex(@"^[0-9]{10}$");
        ///777-777-77-77
        static Regex regexNIPpattern = new Regex(@"^\d{3}-\d{3}-\d{2}-\d{2}");
        ////PL7777777777
        static Regex regexPLpattern = new Regex(@"PL\d{10}");
        public static bool IsNIPValid(string numberToCheck)
        {
          
            
            /// Jeżeli jeden z nich jest spełniony zaakceptuje string
            return (regexTenDigits.Match(numberToCheck).Success ||
                    regexNIPpattern.Match(numberToCheck).Success ||
                    regexPLpattern.Match(numberToCheck).Success);

        }
        public static string GetNIP(string numberToCheck)
        {
            //// 3 uwzględnione wzorce
            ////7777777777
            if (regexTenDigits.Match(numberToCheck).Success)
                return numberToCheck;
            ///777-777-77-77  
            else if (regexNIPpattern.Match(numberToCheck).Success)
                return String.Join("", numberToCheck.Split('-').ToList());
            ////PL7777777777
            else if (regexPLpattern.Match(numberToCheck).Success)
                return numberToCheck.Remove(0, 2);
            else
                return numberToCheck;
        }

        public static void Info(string number)
        {
            if (IsNIPValid(number))
                Console.WriteLine("Numer NIP jest poprawny -- "+number);
            else 
                Console.WriteLine("Numer NIP jest niepoprawny -- " + number);
        }

    }
}
