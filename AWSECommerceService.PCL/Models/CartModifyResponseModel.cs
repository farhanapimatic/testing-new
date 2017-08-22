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
    public class CartModifyResponseModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.OperationRequestModel operationRequest;
        private Models.CartModel cart;

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
        [JsonProperty("Cart")]
        public Models.CartModel Cart 
        { 
            get 
            {
                return this.cart; 
            } 
            set 
            {
                this.cart = value;
                onPropertyChanged("Cart");
            }
        }
    }
} 