using HelloWorldAPI.Services;
using HelloWorldCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldAPI.Controllers
{
    public class HelloWorldController : ApiController
    {

        private readonly IMessageService messageService;
        public HelloWorldController(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        // GET api/Get
        public HelloWorldModel Get()
        {
            return messageService.GetMessage();
        }
    }
}
