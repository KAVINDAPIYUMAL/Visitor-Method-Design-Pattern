using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Method_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDocumentElement> elements = new List<IDocumentElement>
        {
            new Paragraph(),
            new Table()
        };

            IVisitor renderVisitor = new RenderVisitor();
            IVisitor wordCountVisitor = new WordCountVisitor();

            foreach (var element in elements)
            {
                element.Accept(renderVisitor);
                element.Accept(wordCountVisitor);
            }
            Console.ReadLine();
        }
    }
}
