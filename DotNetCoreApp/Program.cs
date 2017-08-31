using DotNetStandard.Whois;
using System;
using System.ServiceModel;

namespace DotNetCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var binder = new BasicHttpBinding();
            binder.UseDefaultWebProxy = false;
            binder.ProxyAddress = new Uri("http://DEFAULTPROXY:8080");

            var remoteAddress = new EndpointAddress("http://www.webservicex.net/whois.asmx");
            var client = new whoisSoapClient(binder, remoteAddress);

            var response = client.GetWhoIS("microsoft.com");
        }
    }
}
