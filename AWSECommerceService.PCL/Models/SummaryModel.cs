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
    public class SummaryModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string promotionId;
        private string message;
        private string category;
        private string startDate;
        private string endDate;
        private string eligibilityRequirementDescription;
        private string benefitDescription;
        private string termsAndConditions;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("PromotionId")]
        public string PromotionId 
        { 
            get 
            {
                return this.promotionId; 
            } 
            set 
            {
                this.promotionId = value;
                onPropertyChanged("PromotionId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Category")]
        public string Category 
        { 
            get 
            {
                return this.category; 
            } 
            set 
            {
                this.category = value;
                onPropertyChanged("Category");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate 
        { 
            get 
            {
                return this.startDate; 
            } 
            set 
            {
                this.startDate = value;
                onPropertyChanged("StartDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate 
        { 
            get 
            {
                return this.endDate; 
            } 
            set 
            {
                this.endDate = value;
                onPropertyChanged("EndDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("EligibilityRequirementDescription")]
        public string EligibilityRequirementDescription 
        { 
            get 
            {
                return this.eligibilityRequirementDescription; 
            } 
            set 
            {
                this.eligibilityRequirementDescription = value;
                onPropertyChanged("EligibilityRequirementDescription");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("BenefitDescription")]
        public string BenefitDescription 
        { 
            get 
            {
                return this.benefitDescription; 
            } 
            set 
            {
                this.benefitDescription = value;
                onPropertyChanged("BenefitDescription");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TermsAndConditions")]
        public string TermsAndConditions 
        { 
            get 
            {
                return this.termsAndConditions; 
            } 
            set 
            {
                this.termsAndConditions = value;
                onPropertyChanged("TermsAndConditions");
            }
        }
    }
} 