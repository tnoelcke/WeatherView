using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models.Tests
{
    [TestClass()]
    public class weatherModelFrameTests
    {

        private weatherModelFrame test;
        [TestInitialize]
        public void setUp()
        {
            test = new weatherModelFrame();
        }

        [TestMethod()]
        public void setCloudForcastTest()
        {
            test.setCloudForcast("CL");
            Assert.AreEqual("Clear", test.getCloudForcast());

            test.setCloudForcast("FW");
            Assert.AreEqual("Mostly Clear", test.getCloudForcast());

            test.setCloudForcast("SC");
            Assert.AreEqual("Scattered Clouds", test.getCloudForcast());

            test.setCloudForcast("BK");
            Assert.AreEqual("Mostly Cloudy", test.getCloudForcast());

            test.setCloudForcast("OV");
            Assert.AreEqual("OverCast", test.getCloudForcast());
        }

        [TestMethod()]
        public void setWindDirectionTest()
        {
            test.setWindDirection("1");
            Assert.AreEqual("N", test.getWindDirection());

            test.setWindDirection("3");
            Assert.AreEqual("NNE", test.getWindDirection());

            test.setWindDirection("4");
            Assert.AreEqual("NE", test.getWindDirection());

            test.setWindDirection("8");
            Assert.AreEqual("E", test.getWindDirection());

            test.setWindDirection("15");
            Assert.AreEqual("SSE", test.getWindDirection());
        }

        [TestMethod()]
        public void setWindSpeedTest()
        {
            const double conversion = 1.1507;
            string windSpeed = "15";
            int wind = 15;
            double mph = Convert.ToInt32(wind * conversion);


            test.setWindSpeed(windSpeed);
            Assert.AreEqual(mph, test.getWindSpeed());
              
        }

    }
}