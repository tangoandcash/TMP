using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex regexTenDigits = new Regex(@"^[0-9]{10}$");
            //Match match = regexTenDigits.Match("3251801126");
            //if (match.Success)
            //{
            //    Console.WriteLine("udalo sie " +match.Value);
            //}
            //else
            //{
            //    Console.WriteLine("nie udalo sie");
            //} 
            //Regex regexNIPpattern = new Regex(@"\d{3}-\d{3}-\d{2}-\d{2}"); 
            //string s = "PL3251801126";
            //Regex regexPLpattern = new Regex(@"PL\d{10}");
            //match = regexPLpattern.Match(s);
            //if (match.Success)
            //{
            //    Console.WriteLine("udalo sie " + match.Value);
            //}
            //else
            //{
            //    Console.WriteLine("nie udalo sie");
            //}
            // Console.WriteLine(s);
            // s.StartsWith("PL").ToString().Remove(0, 2);
            //  s = s.Remove(0, 2);
            // Console.WriteLine(s);
            ValidatorClass.Info("3251801126");
            ValidatorClass.Info("PL3251801126");
            ValidatorClass.Info(ValidatorClass.GetNIP("PL3251801126"));
            ValidatorClass.Info("777-777-77-77");
            ValidatorClass.Info(ValidatorClass.GetNIP("777-777-77-77"));
            ValidatorClass.Info("PL777-777-77-77");
            ValidatorClass.Info(ValidatorClass.GetNIP("PL8887777777"));
            ValidatorClass.Info("7777777777");
            ValidatorClass.Info("7ASDAD77-777-77-77");
            ValidatorClass.Info("77sdffa77");
            ValidatorClass.Info("sdffa");
            ValidatorClass.Info("7777777777");
            ValidatorClass.Info("8887777777");
            ValidatorClass.Info("2227777777");
            ValidatorClass.Info("777-777-77- 77");
            Console.ReadKey();
        }
    }
}
