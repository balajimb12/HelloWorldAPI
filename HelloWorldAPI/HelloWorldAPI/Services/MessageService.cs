using HelloWorldCommon.Models;
using HelloWorldCommon.Resources;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HelloWorldAPI.Services
{
    public class MessageService: IMessageService
    {
        HelloWorldModel model = new HelloWorldModel();
        public HelloWorldModel GetMessage()
        {
            model.Message = "Hello World!";
            return model;
        }
    }
}