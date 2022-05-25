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
            PrintFooterText();

            Console.ReadKey();
        }

        private static void PrintFooterText()
        {
            string FooterText = "Example text";

            DotFooter dot = new DotFooter();
            dot.PrintFooterFormatted(FooterText);

            StarFooter star = new StarFooter();
            star.PrintFooterFormatted(FooterText);

            DashFooter dash = new DashFooter();
            dash.PrintFooterFormatted(FooterText);
        }
    }
}
