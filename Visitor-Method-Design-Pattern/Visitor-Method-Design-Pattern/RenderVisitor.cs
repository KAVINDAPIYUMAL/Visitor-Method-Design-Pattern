using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Method_Design_Pattern
{
    class RenderVisitor : IVisitor
    {
        public void VisitParagraph(Paragraph paragraph)
        {
            Console.WriteLine("Rendering Paragraph");
        }

        public void VisitTable(Table table)
        {
            Console.WriteLine("Rendering Table");
        }
    }
}
