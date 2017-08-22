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
    public class SimilarityLookupResponseModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.OperationRequestModel operationRequest;
        private Models.ItemsModel items;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("OperationRequest")]
        public Models.OperationRequestModel OperationRequest 
        { 
            get 
            {
                return this.operationRequest; 
            } 
            set 
            {
                this.operationRequest = value;
                onPropertyChanged("OperationRequest");
            }
        }

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
    }
} 