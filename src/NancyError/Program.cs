using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Hosting.Self;

namespace NancyError
{
    public class TestBootstrapper : DefaultNancyBootstrapper
    {
    }

    class Program
    {


        static void Main(string[] args)
        {
            var nancyHost = new NancyHost(new TestBootstrapper(), new Uri("http://localhost:8888/testing/"));
            nancyHost.Start();

            Console.ReadKey();

            nancyHost.Stop();

        }
    }
}
