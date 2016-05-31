using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoF.DesignPattern.Decorator;

namespace GoF.DesignPattern
{
    internal class DecoratorMain
    {
        public static void Main()
        {
            Console.WriteLine("Document : Text --> \n");
            DocumentComponent documentComponentText = new BorderDecorator(new FontDecorator(new HeaderAndFooterDecorator(new TextView())));
            documentComponentText.DisplayDocument();
            Console.WriteLine("Total Size : " + documentComponentText.GetSize());

            Console.WriteLine("Document : Graph --> \n");
            DocumentComponent documentComponentGraph = new ScrollBarDecorator(new GraphView());
            documentComponentGraph.DisplayDocument();
            Console.WriteLine("Total Size : " + documentComponentGraph.GetSize());
        }
    }
}
