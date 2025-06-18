using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnilneCourseFunctions.Models
{
    class ResponseContent
    {

        public const string ApiVersion = "1.0.0";

        public ResponseContent()
        {
            version = ApiVersion;
            action = "Continue";
        }

        public ResponseContent(string action, string userMessage)
        {
            version = ApiVersion;
            this.action = action;
            this.userMessage = userMessage;
            if (action == "ValidationError")
            {
                status = "400";
            }
        }

        public string version { get; }
        public string action { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string userMessage { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string status { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string jobTitle { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string extension_userRoles { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string extension_userId { get; set; }
    }


}
