using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class ResponseApi
    { 
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("list")]
        public List<User> Result { get; set; }
    }
}
