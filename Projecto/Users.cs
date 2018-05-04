using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;



namespace Projecto
{
    class Users 
    {
        string id;
        string fullname;
        string username;
        string password;
        


        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "username")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [JsonProperty(PropertyName = "fullname")]
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        [JsonProperty(PropertyName = "password")]
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
