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
    public class SearchBinSetsModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.SearchBinSetModel searchBinSet;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SearchBinSet")]
        public Models.SearchBinSetModel SearchBinSet 
        { 
            get 
            {
                return this.searchBinSet; 
            } 
            set 
            {
                this.searchBinSet = value;
                onPropertyChanged("SearchBinSet");
            }
        }
    }
} 