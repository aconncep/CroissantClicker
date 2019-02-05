using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace CroissantClicker.Common
{
    public class GameExceptions : Exception
    {
        public GameExceptions(string message) : base(message)
        {

        }
    }

    public class InvalidXMLException : GameExceptions
    {
        private static string message = "Invalid XML data. Please check your GameSettings.xml file and try again.";
        public InvalidXMLException() : base(message)
        {

        }
    }

    public class XMLNotFoundException : GameExceptions
    {
        private static string message = "Could not find GameSettings.xml. Make sure it's in the same directory as the game executable and try again.";
        public XMLNotFoundException() : base(message)
        {
            
        }
    }
}
