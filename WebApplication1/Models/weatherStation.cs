using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class weatherStation
    {
        public String Name { get; set; }
        public String Identifier { get; set; }

        private String GfsURL { get; set; }
        private String GfsExURL { get; set; }
        private String NamURL { get; set; }
        private String EnsURL { get; set; }


        public weatherStation(String name, String identifier)
        {
            Name = name;
            Identifier = identifier;
            setUrls();

        }


        /// <summary>
        /// Sets the URLS for the models for getting the Raw data for each station.
        /// </summary>
        private void setUrls()
        {

        }

    }
}