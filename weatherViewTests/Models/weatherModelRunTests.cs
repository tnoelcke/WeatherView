using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WebApplication1.Models.Tests
{
    [TestClass()]
    public class weatherModelRunTests
    {

        //[TestInitialize]
        //public void setUp()
        //{

        //}

        [TestMethod()]
        public void weatherModelRunTest()
        {
            WebClient client = new WebClient();
            string weatherData = client.DownloadString("http://www.nws.noaa.gov/cgi-bin/mos/getmav.pl?sta=KPDX");
            weatherModelRun test = new weatherModelRun(weatherData, true);
        }

        [TestMethod()]
        public void getAverageMaxTempTest()
        {
            
        }

        [TestMethod()]
        public void getAverageMinTempTest()
        {
            
        }

        [TestMethod()]
        public void getAverageTempTest()
        {
            
        }
    }
}