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
        public string Station { get; set; }
        public string runInfo { get; set; }
        private double TotalPrecip { get; set; }
        private int MaxWind { get; set; }
        private double AverageTemp { get; set; }
        private double AverageMaxTemp { get; set; }
        private double AverageMinTemp { get; set; }


        /// <summary>
        /// Constructor with arguments that initializes the model.
        /// </summary>
        /// <param name="modelRun">Raw data from the HTML output from NOAA site</param>
        public weatherModelRun(String modelRun, bool isShort)
        {
            Frames = new List<weatherModelFrame>();
            if (isShort)
            {
                setShortData(modelRun);
            } else
            {
                setLongData(modelRun);
            }
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
        private void setShortData(String run)
        {
            //doing some string processing to get just the data out of the raw HTML file.
            string[] delimiter = { "<PRE>" };
            string[] data = run.Split(delimiter, System.StringSplitOptions.None);
            char[] seperator = { '\n' };
            string[] rowData = data[1].Split(seperator, System.StringSplitOptions.None);
            char[] splitSpace = { ' ' };
            char[] splitBackSlash = { '/' };


            //getting each row of the data that we care about.
            string[] headerRow = rowData[1].Split(splitSpace, System.StringSplitOptions.RemoveEmptyEntries);
            string[] dateRow = rowData[2].Split(splitSpace, System.StringSplitOptions.None);
            string[] hourRow = rowData[3].Split(splitSpace, System.StringSplitOptions.None);
            string[] lowHighRow = rowData[4].Split(splitSpace, System.StringSplitOptions.None);
            string[] tempRow = rowData[5].Split(splitSpace);
            string[] dewPointRow = rowData[6].Split(splitSpace);
            string[] cloudRow = rowData[7].Split(splitSpace);
            string[] windDirRow = rowData[8].Split(splitSpace);
            string[] windSpeedRow = rowData[9].Split(splitSpace);
            string[] precipProbSixRow = rowData[10].Split(splitSpace, System.StringSplitOptions.None);
            string[] precipQuanitySixRow = rowData[12].Split(splitSpace, StringSplitOptions.None);
            string[] preciptTypeRow = rowData[18].Split(splitSpace, StringSplitOptions.None);
            string[] snowFallRow = rowData[19].Split(splitSpace, System.StringSplitOptions.None);

            weatherModelFrame toAdd;

            //data that needs to be parsed and added to the model.
            int maxMinIndex = 1;
            int hourData = 0;
            int currentDate = 1;
            int tempData;
            int dewPointData;
           
            
            
            //do some processing for the data in the header.


            //processing the data and placing it in the correct paramaters in the model.
            for(int i = 0; i < hourRow.Length; i++)
            {
                //each valid frame will have an hour out put that will parse.
                //This ensures that we dont end up with frames that don't make sense like
                //Like the column with all the headers in it.
                if (Int32.TryParse(hourRow[i], out hourData))
                {
                    toAdd = new weatherModelFrame();
                    toAdd.Hour = hourData;

                    //parses the temperature data.
                    Int32.TryParse(tempRow[i], out tempData);
                    toAdd.Temp = tempData;

                    //parses dew point data
                    Int32.TryParse(dewPointRow[i], out dewPointData);
                    toAdd.Dewpoint = dewPointData;

                    //parses Cloud Cover.
                    toAdd.setCloudForcast(cloudRow[i]);

                    

                    if (hourData == 0)
                    {
                        currentDate++;
                    }
                    toAdd.DayMonth = dateRow[currentDate];
                    if(toAdd.Hour == 12 && i > 4)
                    {
                        int minTemp;
                        toAdd.isMax = false;
                        Int32.TryParse(lowHighRow[maxMinIndex], out minTemp);
                        toAdd.MinOrMaxTemp = minTemp;
                        maxMinIndex++;
                    } else if (toAdd.Hour == 0 && i > 4)
                    {
                        int maxTemp;
                        toAdd.isMax = true;
                        Int32.TryParse(lowHighRow[maxMinIndex], out maxTemp);

                    } else
                    {
                        toAdd.MinOrMaxTemp = null;
                    }

                    
                        
                }






            }
            
        }

        /// <summary>
        /// Sets the data for the long range GFSx model as it is different from the
        /// MOS model runs.
        /// </summary>
        /// <param name="run">This string is the entire HTML page that represents the GFS run for the long term.</param>
        private void setLongData(String run)
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