using System;
using System.Diagnostics;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

using OpenCVClient;

namespace OpenCVClientTest
{
    //[TestClass]
    [TestFixture]
    public class UnitTest1
    {
        //[TestMethod]
        [Test]
        public void TestMethod1()
        {
            TestContext.WriteLine("AJB");

            OpenCVClient.OpenCVClient ocvc = new OpenCVClient.OpenCVClient();
            TestContext.WriteLine("AJB");
        }
    }
}
