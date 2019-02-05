using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CroissantClicker.Common
{
    public static class XMLParser
    {
        public static void PopulateGameSettingsFromFile(string inputPath = null)
        {
            XDocument doc;
            try
            {
                string path = inputPath ?? Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\GameSettings.xml";
                doc = XDocument.Load(path);
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new XMLNotFoundException();
            }

            try
            {
                foreach (XElement node in doc.Elements().Elements())
                {
                    if (node.Name == "startingCroissants")
                    {
                        string startingCroissants = node.FirstAttribute.Value;
                        GameData.Croissants = Convert.ToUInt64(startingCroissants);
                    }
                    else if (node.Name == "startingRate")
                    {
                        string startingRate = node.FirstAttribute.Value;
                        GameData.CroissantRate = Decimal.Divide(Convert.ToUInt64(startingRate), 5);
                    }
                    else if (node.Name == "croissantsPerClick")
                    {
                        string croissantsPerClick = node.FirstAttribute.Value;
                        GameData.croissantsPerClick = Convert.ToUInt64(croissantsPerClick);
                    }
                    else if (node.Name == "clicks")
                    {
                        string clicks = node.FirstAttribute.Value;
                        GameData.clicks = (int)Convert.ToUInt64(clicks);
                    }
                }
            }
            catch (Exception)
            {
                throw new InvalidXMLException();
            }



        }

        public static void CreateNewGameSave(string inputPath = null)
        {

            if (inputPath == null)
            {
                string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                string file = System.IO.Path.Combine(path, "GameSettings.xml");
                File.WriteAllText("GameSettings.xml", Properties.Resources.DefaultGameSettings);
            }
            else
            {
                File.WriteAllText(inputPath, Properties.Resources.DefaultGameSettings);
                SaveGameData(inputPath);
            }
            
        }

        public static void SaveGameData(string inputPath = null)
        {
            XDocument doc;
            try
            {
                string path = inputPath ?? Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\GameSettings.xml";
                doc = XDocument.Load(path);

                foreach (XElement node in doc.Elements().Elements())
                {
                    if (node.Name == "startingCroissants")
                    {
                        node.FirstAttribute.SetValue(Convert.ToUInt64(GameData.Croissants));
                    }
                    else if (node.Name == "startingRate")
                    {
                        node.FirstAttribute.SetValue(Convert.ToUInt64(GameData.CroissantRate * 5));
                    }
                    else if (node.Name == "croissantsPerClick")
                    {
                        node.FirstAttribute.SetValue(Convert.ToUInt64(GameData.croissantsPerClick));
                    }
                    else if (node.Name == "clicks")
                    {
                        node.FirstAttribute.SetValue(Convert.ToUInt64(GameData.clicks));
                    }
                }
                doc.Save(path);

            }
            catch (FileNotFoundException) // xml file was deleted while game was running
            {
                CreateNewGameSave(inputPath);
                SaveGameData(inputPath);
            }
        }

        public static void OpenGameFromFile(string path) // when the load button is pressed
        {
            PopulateGameSettingsFromFile(path);
            UIUpdater.UpdateAllLabels();
        }
    }
}
