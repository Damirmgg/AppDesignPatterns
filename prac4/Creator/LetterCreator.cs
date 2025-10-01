using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prac4.Documents;
namespace prac4.Creator
{
    internal class LetterCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Letter();
        }
    }
}
