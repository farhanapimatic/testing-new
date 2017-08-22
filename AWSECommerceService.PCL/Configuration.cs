using System.Collections.Generic;
using System.Text;
using APIMATIC.SDK.Common;
using AWSECommerceService.PCL.Models;
namespace AWSECommerceService.PCL
{
    public partial class Configuration
    {

        public enum Environments
        {
            PRODUCTION,
        }
        public enum Servers
        {
            AWSECOMMERCESERVICEPORT,
            AWSECOMMERCESERVICEPORTCA,
            AWSECOMMERCESERVICEPORTCN,
            AWSECOMMERCESERVICEPORTDE,
            AWSECOMMERCESERVICEPORTES,
            AWSECOMMERCESERVICEPORTFR,
            AWSECOMMERCESERVICEPORTIN,
            AWSECOMMERCESERVICEPORTIT,
            AWSECOMMERCESERVICEPORTJP,
            AWSECOMMERCESERVICEPORTUK,
            AWSECOMMERCESERVICEPORTUS,
        }

        //The current environment being used
        public static Environments Environment = Environments.PRODUCTION;

        //TODO: Replace the AFIeyt with an appropriate value
        public static string AFIeyt = "";

        //TODO: Replace the B with an appropriate value
        public static string B = "";

        //TODO: Replace the C with an appropriate value
        public static string C = "";

        //OAuth 2.0 Access Token
        //TODO: Replace the OAuthAccessToken with an appropriate value
        public static string OAuthAccessToken = "TODO: Replace";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODUCTION,new Dictionary<Servers, string>
                    {
                        { Servers.AWSECOMMERCESERVICEPORT,"https://webservices.amazon.com/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTCA,"https://webservices.amazon.ca/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTCN,"https://webservices.amazon.cn/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTDE,"https://webservices.amazon.de/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTES,"https://webservices.amazon.es/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTFR,"https://webservices.amazon.fr/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTIN,"https://webservices.amazon.in/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTIT,"https://webservices.amazon.it/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTJP,"https://webservices.amazon.co.jp/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTUK,"https://webservices.amazon.co.uk/onca/soap?Service=AWSECommerceService" },
                        { Servers.AWSECOMMERCESERVICEPORTUS,"https://webservices.amazon.com/onca/soap?Service=AWSECommerceService" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:AWSECOMMERCESERVICEPORT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.AWSECOMMERCESERVICEPORT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}