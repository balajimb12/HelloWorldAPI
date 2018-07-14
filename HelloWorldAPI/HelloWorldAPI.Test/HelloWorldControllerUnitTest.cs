using System;
using HelloWorldAPI.Controllers;
using HelloWorldAPI.Services;
using HelloWorldCommon.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorldAPI.Test
{
    [TestClass]
    public class HelloWorldControllerUnitTest
    {
        private Mock<IMessageService> messageServiceMock;
        private HelloWorldController helloWorldController;

        [TestMethod]
        public void TestMethod1()
        {
            this.messageServiceMock = new Mock<IMessageService>();
            this.helloWorldController = new HelloWorldController(this.messageServiceMock.Object);
            var expectedResult = GetSampleTestMessage();

            this.messageServiceMock.Setup(m => m.GetMessage()).Returns(expectedResult);

            var result = this.helloWorldController.Get();

            Assert.AreEqual(result.Message, expectedResult.Message);
        }

        private static HelloWorldModel GetSampleTestMessage()
        {
            return new HelloWorldModel()
            {
                Message = "Hello World!"
            };
        }
    }
}
