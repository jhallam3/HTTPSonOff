using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TurnOnAndOffHTTPS
{
    class Program
    {
        static string hostpath = @"C:\Windows\System32\drivers\etc\hosts";
        static string settingsFile = @"C:\Program Files\Decisions\Decisions Services Manager\Settings.xml";

        static void Main(string[] args)
        {
            //list certs 
            GetHTTPSURLS();
            var httpstouse = Console.ReadLine();
            //get local IP
            GetLocalIPAddress();
            var iptouse = Console.ReadLine();
            //
            //RemoteHostRecord exists
            //
            //get settings xml
            GetCurrentLocalViaString("LocallyAddressableIISWebsiteIPOrDNSName");
            var portalbase = GetCurrentLocalViaString("PortalBaseUrl");
            //portalbase = "https://server/path1/path2/path3";//for testting
            var currentportalURL =getCurrentPortalURL(portalbase);
            var Alias = getAliasIfAny(currentportalURL);

            var NEWPortalHost = "https://"+httpstouse+ "/" + Alias;
            var DoesHostResportExist1 = DoesHostResportExist();
            if (DoesHostResportExist())
            {
                Console.WriteLine("host exists already.");
            }
            else
            {
                UpdateHostsRecord(iptouse, httpstouse);
            }
            




        }

        static public string[] GetHTTPSURLS()
        {
            ServerManager iisManager = new ServerManager();

            Site site = iisManager.Sites["Default Web Site"];
            var b = site.Bindings.ToArray();

            var store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.OpenExistingOnly);

            foreach (var cert in store.Certificates)
            {
                if (!cert.FriendlyName.Contains("IIS Express Development Certificate"))
                {
                    Console.Write("{0} ", cert.FriendlyName);
                    Console.WriteLine();
                }
            }

            return null;

        }


        static public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine( ip.ToString());
                    Console.WriteLine();
                }
            }

            return null;

        }


        static public bool DoesHostResportExist()
        {
            
            var filecontainsDecisionsHostRecord = System.IO.File.ReadAllText(hostpath).Contains("#Added By Decisions");
            return filecontainsDecisionsHostRecord;
        }



        static public bool UpdateHostsRecord(string ip, string hostname)
        {

            try
            {
                System.IO.File.AppendAllText(hostpath, "\r\n");
                System.IO.File.AppendAllText(hostpath, "#Added By Decisions START \r\n");
                System.IO.File.AppendAllText(hostpath, ip + " " + hostname +"\r\n");
                System.IO.File.AppendAllText(hostpath, "#Added By Decisions END \r\n");
                return true;
            }
            catch (Exception)
            {
                return false;
               
            }
        }

        static public bool RemoteHostRecord()
        {
            return false;
        }

        static public string GetCurrentLocalViaString (string tag)
        {
            // this reads the Tag in settings.xml
            var data = "";

            var SettingsFileContents = File.ReadAllLines(settingsFile);
            foreach(var i in SettingsFileContents)
            {
                if (i.Contains("<" + tag +">"))
                {
                    var stop = 1;
                    data = i.Trim();
                    data = data.Replace("<" + tag + ">", string.Empty);
                    data = data.Replace("</" + tag + ">", string.Empty);



                }

            }
            return data;
            //tried to deserialise but get an errror Im over this will just get data from string read
            //Classes.Settings setting = null;
            //string path = @"C:\Program Files\Decisions\Decisions Services Manager\Settings.xml";

            //XmlSerializer serializer = new XmlSerializer(typeof(Classes.Settings));

            //StreamReader reader = new StreamReader(path);
            //setting = (Classes.Settings)serializer.Deserialize(reader);
            //reader.Close();
            //return setting;


        }

        static public Uri getCurrentPortalURL (string hostname)
        {
            var uri = new Uri(hostname);
            return uri;

        }

        static public string GetNewURLbasedOnCurrentHostname (Uri uri, bool httpsOrNot)
        {//this this is crap
            var url = "";
            if (httpsOrNot == true)
            {
                url = "HTTPS:\\";
            }
            else
            {
                url = "HTTP:\\";
            }

            
            

            return null;
        }

        static public string getAliasIfAny(Uri uri)
        {

            try
            {
                return uri.Segments[1].ToString().Replace("/",string.Empty);
            }
            catch (Exception ex2)
            {
                return null;
            }
            
        }
    }
}
