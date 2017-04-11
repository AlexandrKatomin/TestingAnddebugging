using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing_laba_3;
using Moq;
using System.Net;
using System.Collections.Generic;

namespace Tests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestFormationOfUrl() {
            string id = "32638320";
            string access_token = "44b3c3bebd86029c26eb607cc2144247bcaa27c77a55b62922c3d219107b0316c0cc5c263d379e3d2a4a2";
            string url = "https://api.vk.com/method/users.get";
            VkApi vk = new VkApi(new TestrequestProvider());
            string result = vk.GetUsers(url, id, access_token);
            Assert.AreEqual("ok",result);
        }

        [TestMethod]
        public void TestGetOneUser() {
            string id = "32638320";
            string access_token = "44b3c3bebd86029c26eb607cc2144247bcaa27c77a55b62922c3d219107b0316c0cc5c263d379e3d2a4a2";
            string url = "http://localhost:3000/testGetUsers";
            VkApi vk = new VkApi(new RealRequestProvider());
            Error error;
            string expected = "Катомин";
            
            List<User> users = vk.GetUsers(url, id, access_token,out error);
            Assert.AreEqual(expected, users[0].last_name);
        }
    }
}
