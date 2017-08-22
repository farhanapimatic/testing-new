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
    public class PriceModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string formattedPrice;
        private int? amount;
        private string currencyCode;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("FormattedPrice")]
        public string FormattedPrice 
        { 
            get 
            {
                return this.formattedPrice; 
            } 
            set 
            {
                this.formattedPrice = value;
                onPropertyChanged("FormattedPrice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Amount")]
        public int? Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode 
        { 
            get 
            {
                return this.currencyCode; 
            } 
            set 
            {
                this.currencyCode = value;
                onPropertyChanged("CurrencyCode");
            }
        }
    }
} 