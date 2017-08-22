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
    public class CartCreateRequestModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.ItemsModel items;
        private string mergeCart;
        private List<string> responseGroup;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Items")]
        public Models.ItemsModel Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MergeCart")]
        public string MergeCart 
        { 
            get 
            {
                return this.mergeCart; 
            } 
            set 
            {
                this.mergeCart = value;
                onPropertyChanged("MergeCart");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ResponseGroup")]
        public List<string> ResponseGroup 
        { 
            get 
            {
                return this.responseGroup; 
            } 
            set 
            {
                this.responseGroup = value;
                onPropertyChanged("ResponseGroup");
            }
        }
    }
} 