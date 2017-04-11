using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Testing_laba_3 {
    class Program {

        static void main1(string[] args) {        
            /*
            Api vk = new Api(new RealProvider());
            string response=vk.UsersGet(url, id, access_token);
            JObject responseJson1 = JObject.Parse(response);
          //  Console.WriteLine(responseJson1);
            if (response.IndexOf("error")!=-1) {
                JObject responseJson = JObject.Parse(response);
                JToken err = responseJson["error"]["error_msg"];
               // Console.WriteLine(err);
            } else {
                IList<JToken> results = responseJson1["response"].Children().ToList();
                IList<User> searchResults = new List<User>();
                foreach (JToken result in results)         {
                    // JToken.ToObject is a helper method that uses JsonSerializer internally
                    User searchResult = result.ToObject<User>();
                    searchResults.Add(searchResult);
                    }
                Console.ReadLine();

            */
            /*
                Error error = JsonConvert.DeserializeObject<Error>(responseJson);
               string str = error.error_msg;
               string ser = JsonConvert.SerializeObject(error);
               Console.Write(ser);
               */
            Console.Read();
        }


        static void Main(string[] args) {
            //string id = "32638320,166809255";
            string id = "32638320";
            string access_token = "44b3c3bebd86029c26eb607cc2144247bcaa27c77a55b62922c3d219107b0316c0cc5c263d379e3d2a4a2";
            string url = "https://api.vk.com/method/users.get";
            VkApi vk = new VkApi(new RealRequestProvider());
            Error error;
            List<User> users=vk.GetUsers(url, id, access_token, out error);

            vk = new VkApi(new TestrequestProvider());
            string result=vk.GetUsers(url, id, access_token);





        }


               



        
    }
}

