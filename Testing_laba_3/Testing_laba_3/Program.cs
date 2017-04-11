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

