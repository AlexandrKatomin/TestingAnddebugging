using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Testing_laba_3 {

    // чтобы использовать паттерн  Адаптер для класс WebRequest
    // надо реализовать метод GetResponse(), который возвращает  webResponse
    // но нет  конструктора webResponse
    // я не знаю, как создать обькт webResponse
    //
    public abstract class RequestProvider {
        public abstract string GetResponse(string url);
    }

    public class RealRequestProvider : RequestProvider {
        public override string GetResponse(string url) {
            string resalt = "";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream()) {
                using (StreamReader reader = new StreamReader(stream)) {
                    string line = "";
                    while ((line = reader.ReadLine()) != null) {
                        resalt += line;
                    }
                }
            }
            response.Close();
            return resalt;
        }
    }
    //если я правильно понял, то в TestrequestProvider 
    //надо протестировать параметры которые мы передаем в RealRequestProvider
    // но тест выглядит сомнительно
    
    public class TestrequestProvider : RequestProvider {
            public override string GetResponse(string url) {
            string testUrl = "https://api.vk.com/method/users.get" +

                "?user_ids=32638320" +
                "&access_token=44b3c3bebd86029c26eb607cc2144247bcaa27c77a55b62922c3d219107b0316c0cc5c263d379e3d2a4a2" +
                "&v=5.62";

                if (url == testUrl) {
                    return "ok";
                } else {
                    return "error";
                }
            }

        }
    
}
