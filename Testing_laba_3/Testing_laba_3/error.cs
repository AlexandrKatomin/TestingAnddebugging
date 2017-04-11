using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Testing_laba_3 {

  //  [JsonObject]
    public class Error {
    //    [JsonProperty("error_code")]
        public string error_code { get; set; }
    //    [JsonProperty("error_msg")]
        public string error_msg { get; set; }
  //      [JsonProperty("request_params")]
        public KeyAndValue[] request_params { get; set; }
    }

    public class KeyAndValue {

        public string key { get; set; }
        public string value { get; set; }
    }
}
