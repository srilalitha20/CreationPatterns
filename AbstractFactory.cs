using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public interface IRestaurantFactory
   {
       IinputReader Reader(string readerChoice);
       IMenuGenerator MenuGenerator();
       IMenuOutputFormatter MenuOutputFormatter(string outputChoice);
   }

   class AmericanRestaurant : IRestaurantFactory
   {
       public IinputReader Reader(string readerChoice)
       {
           IinputReader reader = null;
           switch (readerChoice)
           {
               case "xml":
                   reader = new xmlRead();
                   break;
               case "json":
                   reader = new jsonRead();
                   break;
               default:
                   break;
           }

           return reader;
       }
       public IMenuGenerator MenuGenerator()
       {
           return new clsMenuGenerator();
       }
       public IMenuOutputFormatter MenuOutputFormatter(string outputChoice)
       {
           IMenuOutputFormatter outputFormatter = null;
           switch (outputChoice)
           {
               case "xml":
                   outputFormatter = new clsMenuOutputFormatterXml();
                   break;
               case "txt":
                   outputFormatter = new clsOutputFormatterPlainText();
                   break;
               case "html":
                   outputFormatter = new clsMenuOutputFormatterHtml();
                   break;
               default:
                   break;
           }

           return outputFormatter;
       }
   }
   class BritishRestaurant : IRestaurantFactory
   {
       public IinputReader Reader(string readerChoice)
       {
           IinputReader reader = null;
           switch (readerChoice)
           {
               case "xml":
                   reader = new xmlRead();
                   break;
               case "json":
                   reader = new jsonRead();
                   break;
               default:
                   break;
           }

           return reader;
       }
       public IMenuGenerator MenuGenerator()
       {
           return new clsMenuGenerator();
       }
       public IMenuOutputFormatter MenuOutputFormatter(string outputChoice)
       {
           IMenuOutputFormatter outputFormatter = null;
           switch (outputChoice)
           {
               case "xml":
                   outputFormatter = new clsMenuOutputFormatterXml();
                   break;
               case "txt":
                   outputFormatter = new clsOutputFormatterPlainText();
                   break;
               case "html":
                   outputFormatter = new clsMenuOutputFormatterHtml();
                   break;
               default:
                   break;
           }

           return outputFormatter;
       }
   }

    class AbstractFactory
    {
    }
}
