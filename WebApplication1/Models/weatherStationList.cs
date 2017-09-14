using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class weatherStationList
    {
        public List<weatherStation> WeatherStations { get; set; }

        public weatherStationList(String weatherStations)
        {
            setData(weatherStations);    
        }

        /// <summary>
        /// Takes the list of weather stations and creates entries for the
        /// weather stations so they can be entered into a URL.
        /// </summary>
        /// <param name="weatherStations"></param>
        private void setData(String weatherStations)
        {
            
        }
    }
}