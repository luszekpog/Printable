using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printable
{
    internal class StarFooter : IPrintable
    {
        public void PrintFooterFormatted(string footerText)
        {
            Console.WriteLine("*****" + footerText + "*****");
        }
    }
}
