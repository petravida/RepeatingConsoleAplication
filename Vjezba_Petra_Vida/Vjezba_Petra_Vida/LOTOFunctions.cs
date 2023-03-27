using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Petra_Vida
{
    public class LOTOFunctions
    {
        public void RendomNumber()
        {
            Console.Clear();
            Random randomNumber = new Random();
            for (int i = 0;  i < 7; i++) 
            {
                Console.WriteLine(randomNumber.Next(45));
            }
            Console.ReadLine();
        }
        //public void PDFFile()
        //{
        //    string novadatoteka = ($"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\WebApiCSharp\\Ponavljanje ConsoleAplication\\");
        //    if (!Directory.Exists(pdfdatoteka))
        //    {
        //        Directory.CreateDirectory(pdfdatoteka);
        //    }
        //    PdfDocument pdfFile = new PdfDocument();
        //    PdfPage pdfPage = new PdfPage();
        //    pdfFile.AddPage(pdfPage);
        //    XGraphics graph = XGraphics.FromPdfPage(pdfPage);
        //    XFont latters = new XFont("Comics", 25);
        //    XPoint place = new XPoint(35, 35);
        //    LOTOFunctions numberForPDF = new LOTOFunctions();
        //    graph.DrawString($"There is your numbers {numberForPDF.RendomNumber()}", latters, XBrushes.Black, place);
        //    //graph.DrawString("Trying to make my first PDF document.", latters, XBrushes.BlueViolet, place);
        //    //string fileName = "MyFirstPDFFile.pdf";
        //    //myFile.Save($"{novadatoteka}\\{fileName}");
        //    //Process.Start(fileName);

        //    Console.ReadLine();

        //    string txtFile = File.ReadAllText($"C:\\Users\\donii\\OneDrive\\Radna površina\\petramono\\textzaprobu.txt");

        //}
    }
}
