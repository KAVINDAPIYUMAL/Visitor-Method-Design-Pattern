using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Method_Design_Pattern
{
    class Table : IDocumentElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitTable(this);
        }
    }
}
