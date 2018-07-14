using HelloWorldCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldAPI.Services
{
    public interface IMessageService
    {
        HelloWorldModel GetMessage();
    }
}