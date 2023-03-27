using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Petra_Vida
{
    public class LOTOFunctions
    {
        public int[] RandomNumber()
        {
            Console.Clear();
            int[] arrayOfRandoms = new int[7];
            Random randomNumber = new Random();
            for (int i = 0;  i < 7; i++) 
            {
                int random = randomNumber.Next(45); ;
                while (arrayOfRandoms.Contains(random)) {
                    random = randomNumber.Next(45);
                }
                arrayOfRandoms[i] = random;

                Console.WriteLine(arrayOfRandoms[i]);
            }
            Console.ReadLine();
            return arrayOfRandoms;
        }
        public void PDFFile()
        {
            string novadatoteka = ($"C:\\Users\\donii\\OneDrive\\Dokumenti\\RepeatingConsoleAplication\\Vjezba_Petra_Vida");
            if (!Directory.Exists(novadatoteka))
            {
                Directory.CreateDirectory(novadatoteka);
            }
            PdfDocument pdfFile = new PdfDocument();
            PdfPage pdfPage = new PdfPage();
            pdfFile.AddPage(pdfPage);
            Random random = new Random();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont latters = new XFont("Comics", 15);

            //XRect rec = new XRect(35, 35, pdfPage.Width - 100, pdfPage.Height - 100);
            XTextFormatter form = new XTextFormatter(graph);

            //LOTOFunctions numberForPDF = new LOTOFunctions();
            int[] pdfNumbers = RandomNumber();
            int x = 50;
            foreach (int number in pdfNumbers) {
                x = x + 50;
                XPoint place = new XPoint(x, 50);
                graph.DrawString($"{number}", latters, XBrushes.Black, place);
                 }
            string fileName = "MyPDFFile.pdf";
            pdfFile.Save($"{novadatoteka}\\{fileName}");
            Process.Start(fileName);

            Console.ReadLine();


        }
    }
}
