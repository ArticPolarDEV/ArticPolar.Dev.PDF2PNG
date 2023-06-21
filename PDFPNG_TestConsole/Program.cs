using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticPolar.Dev.PDF2PNG;

namespace PDFPNG_TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PDF2PNG converter = new PDF2PNG();
            converter.ConvertPdfToPng(args[0], args[1]);
            Console.WriteLine("The PDF: " + args[0] + " is converted in Folder: " + args[1]);
        }
    }
}
