using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_basic_1.BaseClasses
{
    public class jsonreader
    {
        public string? extractdata(String tokenName)
        {
            var myJsonString = File.ReadAllText("utility/testdata.json");

            var jsonObject = JToken.Parse(myJsonString);
            return jsonObject.SelectToken(tokenName).Value<string>();
        }

    }
}
