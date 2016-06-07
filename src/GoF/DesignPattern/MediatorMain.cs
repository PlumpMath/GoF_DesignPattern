using System;
using GoF.DesignPattern.Mediator;

namespace GoF.DesignPattern
{
    internal class MediatorMain
    {
        public static void Main(string[] args)
        {
            var data = "Hello World !";
            AbstractMediator abstractMediator = new Mediator.Mediator();

            AbstractPrinter textPrinter = new TextPrinter(abstractMediator);
            AbstractPrinter xmlPrinter = new XmlPrinter(abstractMediator);
            AbstractPrinter htmlPrinter = new HtmlPrinter(abstractMediator);

            abstractMediator.Register(textPrinter);
            abstractMediator.Register(xmlPrinter);
            abstractMediator.Register(htmlPrinter);

            Console.WriteLine("Text Printer talking ......\n");
            textPrinter.Print(data, textPrinter.PrinterType);
            textPrinter.PrintToOtherFormat(data, xmlPrinter.PrinterType, textPrinter.PrinterType);

            Console.WriteLine("\nText Printer talking ......\n");
            xmlPrinter.Print(data, xmlPrinter.PrinterType);
            xmlPrinter.PrintToOtherFormat(data, textPrinter.PrinterType, xmlPrinter.PrinterType);

            Console.WriteLine("\nText Printer talking ......\n");
            htmlPrinter.PrintToOtherFormat(data, xmlPrinter.PrinterType, htmlPrinter.PrinterType);
        }
    }
}
