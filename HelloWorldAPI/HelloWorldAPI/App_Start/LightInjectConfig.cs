using System;
using System.Collections.Generic;
using System.Linq;
using LightInject;
using System.Web.Http;
using HelloWorldAPI.Services;

namespace HelloWorldAPI.App_Start
{
    public static class LightInjectConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new ServiceContainer();
            container.RegisterApiControllers();

            container.EnablePerWebRequestScope();
            container.EnableWebApi(GlobalConfiguration.Configuration);

            // Register Services
            RegisterServices(container);
        }

        private static void RegisterServices(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IMessageService, MessageService>();
        }
    }
}