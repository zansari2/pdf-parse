using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace pdf_parser
{
    public static class PdfImport
    {
        public static string pdfText(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            return text;
        }
        public static void printString(string inpath,string outpath)
        {
            System.IO.File.WriteAllText(outpath,pdfText(inpath));
        }
    }

}
