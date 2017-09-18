using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class weatherModelFrame
    {
        public const double KNOTS_TO_MPH = 1.1507;
        //keeps track of the day of the month
        public string DayOfTheMonth { get; set; }
        //keeps track of the forcast hour
        public int Hour { get; set; }
        //keeps track of the minimum or maximum temp in a 24 hour period
        //will be null most of the time.
        bool isMax { get; set; }
        public int? MinOrMaxTemp { get; set; }
        //keeps track of the temp.
        public int Temp { get; set; }
        //keeps track of the dewpoint
        public int Dewpoint { get; set; }
        //keeps track of the cloud forcast will need to be set
        //by another function.
        private string CloudForcast { get; set; }
        //keeps track of the wind direction
        //will need to be set by a function.
        private string WindDirection { get; set; }
        //keeps track of wind speed in knots
        //will set using a function so it can be converted.
        private int WindSpeed { get; set; }
        //keeps track of the 6 hour probability of precip.
        public int? SixHourPrecipProbablity { get; set; }
        //keeps track of the six hour precip
        public int? SixHourPrecip { get; set; }
        //keeps track of the 24 hour snow fall.
        public int? SnowFall { get; set; }
        //tracks the probibilty of frozen precip
        public int FreezingProbability { get; set; }
        

        /// <summary>
        /// This functino sets the cloud forcast such that the two letter code
        /// is displayed correctly.
        /// </summary>
        /// <param name="toSet">
        /// This is the two letter code that comes from the text out put of the
        /// GFS model.
        /// </param>

        public void setCloudForcast(string toSet)
        {
            if(toSet.ToUpper().Equals("CL"))
            {
                CloudForcast = "Clear";
            } else if (toSet.ToUpper().Equals("FW"))
            {
                CloudForcast = "Mostly Clear";
            } else if (toSet.ToUpper().Equals("SC"))
            {
                CloudForcast = "Scattered Clouds";
            } else if (toSet.ToUpper().Equals("BK"))
            {
                CloudForcast = "Mostly Cloudy";
            } else
            {
                CloudForcast = "OverCast";
            }
        }

        /// <summary>
        /// Gets the CloudForcast variable
        /// </summary>
        /// <returns>CloudForcast</returns>
        public string getCloudForcast()
        {
            return CloudForcast;
        }

        /// <summary>
        /// Sets the windDirectionVariable
        /// </summary>
        /// <param>
        /// windDirection is a paramater that represents as
        /// wind direction this direction will be between 0 and 36
        /// </param>
        public void setWindDirection(string windDirection)
        {
            int wind;
            Int32.TryParse(windDirection, out wind);
            switch (wind) {
                case 1:
                case 35:
                case 36:
                    WindDirection = "N";
                    break;
                case 2:
                case 3:
                    WindDirection = "NNE";
                    break;
                case 4:
                case 5:
                    WindDirection = "NE";
                    break;
                case 6:
                case 7:
                    WindDirection = "ENE";
                    break;
                case 8:
                case 9:
                case 10:
                    WindDirection = "E";
                    break;
                case 11:
                case 12:
                    WindDirection = "ESE";
                    break;
                case 13:
                case 14:
                    WindDirection = "SE";
                    break;
                case 15:
                case 16:
                    WindDirection = "SSE";
                    break;
                case 17:
                case 18:
                case 19:
                    WindDirection = "S";
                    break;
                case 20:
                case 21:
                    WindDirection = "SSW";
                    break;
                case 22:
                case 23:
                    WindDirection = "SW";
                    break;
                case 24:
                case 25:
                    windDirection = "WSW";
                    break;
                case 26:
                case 27:
                case 28:
                    WindDirection = "W";
                    break;
                case 29:
                case 30:
                    WindDirection = "WNW";
                    break;
                case 31:
                case 32:
                    WindDirection = "NW";
                    break;
                case 33:
                case 34:
                    WindDirection = "NNW";
                    break;
            }
        }
        /// <summary>
        /// Returns the wind direction
        /// </summary>
        /// <returns>WindDirection</returns>
        public string getWindDirection()
        {
            return WindDirection;
        }
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="windSpeed"></param>
        public void setWindSpeed(string windSpeed)
        {
            int wind;
            Int32.TryParse(windSpeed, out wind);
            double initialSpeed = KNOTS_TO_MPH * wind;
            WindSpeed =  Convert.ToInt32(initialSpeed); 
        }
        
        public int getWindSpeed()
        {
            return WindSpeed;
        }
    }
}