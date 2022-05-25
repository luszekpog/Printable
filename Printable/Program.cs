using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DotFooter dot = new DotFooter();
            StarFooter star = new StarFooter();
            DashFooter dash = new DashFooter();
            PrintFooterText(dot);
            PrintFooterText(star);
            PrintFooterText(dash);

            Console.ReadKey();
        }

        private static void PrintFooterText(IPrintable printable)
        {
            string FooterText = "Example text";

            printable.PrintFooterFormatted(FooterText);
        }
    }
}
