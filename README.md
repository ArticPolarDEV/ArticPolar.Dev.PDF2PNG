# ArticPolar.Dev.PDF2PNG
Convert PDF with one or more pages to PNG

## Example of Use
````
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
````

*Example of Use:* PDFPNG_TestConsole.exe C:\Users\User\Desktop\PDFTEST.pdf C:\Users\User\Desktop\PDF1

*Output of Example:* The PDF: C:\Users\User\Desktop\PDFTEST.pdf is converted in Folder: C:\Users\User\Desktop\PDF1


## Requeriment
*Ghostscript AGPL*: https://ghostscript.com/releases/gsdnld.html
