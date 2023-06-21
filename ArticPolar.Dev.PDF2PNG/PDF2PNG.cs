using System;
using Ghostscript.NET;
using Ghostscript.NET.Rasterizer;
using System.Drawing;
using System.IO;
namespace ArticPolar.Dev.PDF2PNG
{
    public class PDF2PNG
    {
        public void ConvertPdfToPng(string pdfFilePath, string outputDirectory)
        {
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }
            using (var rasterizer = new GhostscriptRasterizer())
            {
                rasterizer.Open(pdfFilePath);
                for (int pageNumber = 1; pageNumber <= rasterizer.PageCount; pageNumber++)
                {
                    using (var image = rasterizer.GetPage(96, pageNumber))
                    {
                        var outputFilePath = Path.Combine(outputDirectory, "Page_" + pageNumber + ".png");
                        image.Save(outputFilePath, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }
        }
    }
}