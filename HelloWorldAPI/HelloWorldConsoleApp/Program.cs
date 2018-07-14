using HelloWorldConsoleApp.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var helloWorldService = new HelloWorldService(new RestClient(), new RestRequest());
            Console.WriteLine(helloWorldService.GetMessage().Message);
            Console.ReadLine();
        }
    }
}
