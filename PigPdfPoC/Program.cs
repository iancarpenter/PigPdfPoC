using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace PigPdfPoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (PdfDocument document = PdfDocument.Open(@"C:\Temp\EMegane.pdf"))
            {
                foreach (Page page in document.GetPages())
                {
                    string pageText = page.Text; 
                    
                    foreach (Word word in page.GetWords())
                    {
                        Console.WriteLine(word.Text);
                    }
                }
            }
        }
    }
}