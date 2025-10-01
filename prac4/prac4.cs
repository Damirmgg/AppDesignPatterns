using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prac4.Documents;
using prac4.Creator;
namespace prac4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentCreator[] creators = new DocumentCreator[]
            {
                new LetterCreator(),
                new ResumeCreator(),
                new ReportCreator() 
            };
            foreach (DocumentCreator creator in creators)
            {
                Document document = creator.CreateDocument();
                document.Open();
            }
        }
    }
}
