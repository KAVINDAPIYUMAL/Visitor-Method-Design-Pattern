using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Method_Design_Pattern
{
    interface IDocumentElement
    {
        void Accept(IVisitor visitor);
    }
}
