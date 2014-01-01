using Mono.Options;
using System;
using System.Collections.Generic;

namespace clear
{
    class Program
    {
        static void Main(string[] args)
        {
            bool show_help = false;

            var p = new OptionSet() {
                {"h|help", "Show help and credits",
                 v => show_help = v != null }
            };

            // parse command line
            List<string> extra;
            try
            {
                extra = p.Parse(args);
            }
            catch(OptionException e)
            {
                Console.Write("clear: ");
                Console.WriteLine(e.Message);
                return;
            }

            if (show_help)
            {
                ShowHelp(p);
                return;
            }

            Console.Clear();
        }

        static void ShowHelp(OptionSet p)
        {
            Console.WriteLine("Usage: clear [-h,--help]");
            Console.WriteLine("This clears the command prompt screen. Similiar to the use of 'cls.exe'.");
            Console.WriteLine();
            Console.WriteLine("Written by Sam Contapay. Open sourced and available at http://www.github.com/madgeekfiend. MIT license.");
            Console.WriteLine();
            p.WriteOptionDescriptions(Console.Out);
        }
    }
}
