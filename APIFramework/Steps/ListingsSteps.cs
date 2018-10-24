using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Configuration;
using System.Collections.Generic;
using APIFramework.Utils;
using System.Threading;
using APIFramework;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;
using RestSharp;
using System.Net.Http.Headers;
using NUnit.Framework;

namespace APIFramework
{

    [Binding]
    public class ListingsSteps
    {

        public static JToken rsp;

        [Given(@"I have called the following api:")]
        public void GivenIHaveNavigatedToTheSpecifiedAPI(Table table)
        {
            //Store parameters in dictionary table
            var api = table.CreateInstance<API>();
            var client = new RestClient(api.Endpoint);
            var request = new RestRequest();
            System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            IRestResponse response = client.Execute(request);

            //Store response in a variable that can be accessed by other methods
            rsp = JToken.Parse(response.Content);
            
        }
        
        [Then(@"the response should contain the field (.*) with the value set to (.*)")]
        public void ThenTheResponseShouldContain(string field, string value)
        {
            //loop through each element in response
            foreach (JProperty x in rsp)
            {
                if (x.Name == field)
                {
                    switch (x.Value.Type)
                    {
                        case JTokenType.Boolean:
                            Assert.AreEqual((bool)x.Value, Convert.ToBoolean(value));
                            return;
                        case JTokenType.String:
                            Assert.AreEqual((string)x.Value, value);
                            return;
                        case JTokenType.Integer:
                            Assert.AreEqual((int)x.Value, Convert.ToInt64(value));
                            return;
                        case JTokenType.Float:
                            Assert.AreEqual((float)x.Value, float.Parse(value));
                            return;
                    }
                }
            }
            //Case for when field is not found in response
            Assert.AreEqual(null, value);
        }


        [Then(@"the (.*) element with the (.*) (.*), should have a child (.*) field that contains the text (.*)")]
        public void ThenTheResponseShouldContain(string element, string field, string value, string childfield, string childvalue)
        {
            string foundfieldvalue = String.Empty;

            foreach (var child in rsp[element].Children())
            {
                if ((string)child.SelectToken(field) == value)
                {
                    foundfieldvalue = (string)child.SelectToken(childfield);
                    break;
                }

            }
            Assert.IsTrue(foundfieldvalue.Contains(childvalue));
        }

    }
}
