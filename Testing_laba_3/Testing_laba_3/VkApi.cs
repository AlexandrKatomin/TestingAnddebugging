using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Testing_laba_3 {
    public abstract class Api3 {
        public abstract string UsersGet(string url, string users, string access_token);
    }
    public class VkApiOld :Api3 {
        public override string UsersGet(string url,string users,string access_token) {
            string url1 = url;
            url1 += "?user_ids="+users +"&access_token=" + access_token + "&v=5.62";
            string resalt = "";
            WebRequest request = WebRequest.Create(url1);
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream()) {
                using (StreamReader reader = new StreamReader(stream)) {
                    string line = "";
                    while ((line = reader.ReadLine()) != null) {
                        resalt += line;
                        //Console.WriteLine(line);
                    }
                }
            }
            response.Close();
             Console.WriteLine("Запрос выполнен");
            Console.WriteLine(resalt);
            return resalt;
        }
        
    }
}
