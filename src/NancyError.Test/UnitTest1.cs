using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nancy;
using Nancy.Security;
using Nancy.Testing;
using NancyError;

namespace NancyError.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var boot = new TestBootstrapper();

            var browser = new Browser(boot);

            var response = browser.Get("/", (with) =>
            {
                with.HttpRequest();
                //with.FormsAuth(session.Id, this.authConfig);
            });

            var bob = response;
        }
    }
}
