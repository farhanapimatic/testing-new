/*
 * AWSECommerceService.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;


namespace AWSECommerceService.PCL.Models
{
    public class NonNegativeIntegerWithUnitsModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string units;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Units")]
        public string Units 
        { 
            get 
            {
                return this.units; 
            } 
            set 
            {
                this.units = value;
                onPropertyChanged("Units");
            }
        }
    }
} 