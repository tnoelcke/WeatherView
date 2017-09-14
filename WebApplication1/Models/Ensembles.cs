using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Ensembles
    {
        List<weatherModelRun> Runs { get; set; }

        public Ensembles()
        {
            Runs = new List<weatherModelRun>();
        }

        public Ensembles(String modelData)
        {
            Runs = new List<weatherModelRun>();
            setData(modelData);
        }


        /// <summary>
        /// Loops through a series of model runs contained in a master list of runs for the
        /// NOAA ensemble run.
        /// </summary>
        /// <param name="modelData">raw HTML data from NOAA website</param>
        public void setData(String modelData)
        {

        }
    }
}