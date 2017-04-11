using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Testing_laba_3 {
    public class VkApi {
        
       protected RequestProvider requestProvider { get;  set; }

        public VkApi(RequestProvider requestProvider) {
            this.requestProvider = requestProvider;
        }
        public string GetUsers(string url, string users, string access_token) {
            string urlСomplete = url + "?user_ids=" + users + "&access_token=" + access_token + "&v=5.62";
            return requestProvider.GetResponse(urlСomplete);
        }

        public  List<User> GetUsers(string url, string users, string access_token,out Error error) {
            //формирование url
            string urlСomplete = url + "?user_ids=" + users + "&access_token=" + access_token + "&v=5.62";
            //выполнение запроса
            string response = requestProvider.GetResponse(urlСomplete);
           
            //десериализация
            List<User> listUsers = DeserialiseResponse(out error, response);
            return listUsers;
        }

         JToken GetJToken(string nameToken, string response) {
            JObject responseJson = JObject.Parse(response);
            return responseJson[nameToken];

        }

          List<User> deserialize(string nameToken, string response) {
            IList<JToken> results = GetJToken(nameToken, response).Children().ToList();
            List<User> searchResults = new List<User>();
            foreach (JToken result in results) {
                User searchResult = result.ToObject<User>();
                searchResults.Add(searchResult);
            }
            return searchResults;
        }

         List<User> DeserialiseResponse(out Error error, string response) {
            List<User> listUsers = new List<User>();
            if (response.IndexOf("error") != -1) {
                JToken err = GetJToken("error", response);
                error = err.ToObject<Error>();
            } else {
                error = new Error();
                listUsers = deserialize("response", response);
            }
            return listUsers;
        }
    }
   
}
