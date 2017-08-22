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
    public class HTTPHeadersModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.HeaderModel header;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Header")]
        public Models.HeaderModel Header 
        { 
            get 
            {
                return this.header; 
            } 
            set 
            {
                this.header = value;
                onPropertyChanged("Header");
            }
        }
    }
} 