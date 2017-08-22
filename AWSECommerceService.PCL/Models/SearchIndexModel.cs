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
    public class SearchIndexModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string indexName;
        private Models.CorrectedQueryModel correctedQuery;
        private int relevanceRank;
        private List<string> aSIN;
        private int? results;
        private int? pages;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName 
        { 
            get 
            {
                return this.indexName; 
            } 
            set 
            {
                this.indexName = value;
                onPropertyChanged("IndexName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CorrectedQuery")]
        public Models.CorrectedQueryModel CorrectedQuery 
        { 
            get 
            {
                return this.correctedQuery; 
            } 
            set 
            {
                this.correctedQuery = value;
                onPropertyChanged("CorrectedQuery");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RelevanceRank")]
        public int RelevanceRank 
        { 
            get 
            {
                return this.relevanceRank; 
            } 
            set 
            {
                this.relevanceRank = value;
                onPropertyChanged("RelevanceRank");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ASIN")]
        public List<string> ASIN 
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
        [JsonProperty("Results")]
        public int? Results 
        { 
            get 
            {
                return this.results; 
            } 
            set 
            {
                this.results = value;
                onPropertyChanged("Results");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Pages")]
        public int? Pages 
        { 
            get 
            {
                return this.pages; 
            } 
            set 
            {
                this.pages = value;
                onPropertyChanged("Pages");
            }
        }
    }
} 