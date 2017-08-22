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
    public class SimilarProductModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string aSIN;
        private string title;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ASIN")]
        public string ASIN 
        { 
            get 
            {
                return this.aSIN; 
            } 
            set 
            {
                this.aSIN = value;
                onPropertyChanged("ASIN");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Title")]
        public string Title 
        { 
            get 
            {
                return this.title; 
            } 
            set 
            {
                this.title = value;
                onPropertyChanged("Title");
            }
        }
    }
} 