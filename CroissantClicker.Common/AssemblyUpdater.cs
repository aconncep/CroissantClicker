using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CroissantClicker.Common
{
    public class AssemblyUpdater
    {
        private static string tempPath = Path.GetTempPath() + "version_info.xml";
        private static string remoteCurrentVersionURL = "http://208.123.116.166/CroissantClicker/CurrentVersion/version_info.xml";
        public static void CheckForUpdates()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(remoteCurrentVersionURL, tempPath);
            }

            XDocument doc;
            try
            {
                string path = tempPath;
                doc = XDocument.Load(path);

                foreach (XElement node in doc.Elements().Elements())
                {
                    if (node.Name == "version")
                    {
                        string versionNumber = node.Value;
                        Debug.WriteLine(versionNumber);
                    }
                }

               File.Delete(tempPath);
            }
            catch (Exception)
            {
                throw new Exception();
            }

        }
    }
}
