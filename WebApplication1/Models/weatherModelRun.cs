using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class weatherModelRun
    {
        List<weatherModelFrame> Frames { get; set; }
        private double TotalPrecip { get; set; }
        private int MaxWind { get; set; }
        private double AverageTemp { get; set; }
        private double AverageMaxTemp { get; set; }
        private double AverageMinTemp { get; set; }


        /// <summary>
        /// Constructor with arguments that initializes the model.
        /// </summary>
        /// <param name="modelRun">Raw data from the HTML output from NOAA site</param>
        public weatherModelRun(String modelRun)
        {
            Frames = new List<weatherModelFrame>();
            setData(modelRun);
            maxWind();
            totalPrecip();
            averageTemp();
            averageMaxTemp();
            averageMinTemp();
            
        }

        /// <summary>
        /// Calculates the averageMaxTemp through out the run.
        /// </summary>
        /// <returns>The average maxt temp as a double</returns>
        private void averageMaxTemp()
        {

        }

        /// <summary>
        /// Calculates the averageMinTemp through out a run.
        /// </summary>
        /// <returns>averageMinTemp through out a run</returns>
        private void averageMinTemp()
        {

        }

        /// <summary>
        /// Calculates the average temp through out a run. Sets average temp variable
        /// </summary>
        private void averageTemp()
        {

        }

        /// <summary>
        /// Calculates and sets max wind for the entire run.
        /// </summary>
        private void maxWind()
        {

        }

        /// <summary>
        /// calculates and sets totalPrecip for a run.
        /// </summary>
        private void totalPrecip()
        {

        }

        /// <summary>
        /// sets the data in the list of frames based on the 
        /// raw HTML data from NOAA site.
        /// </summary>
        /// <param name="run">takes a whole run from the NOAA site and initializes the data</param>
        private void setData(String run)
        {

        }

        public double getAverageMaxTemp()
        {
            return AverageMaxTemp;
        }

        public double getAverageMinTemp()
        {
            return AverageMinTemp;
        }

        public double getAverageTemp()
        {
            return AverageTemp;
        }
    }
}