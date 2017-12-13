using System;
using System.Collections.Generic;
using System.Text;

namespace XamagramTest.InstagramApi
{
    public class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public string full_name { get; set; }
        public string profile_picture { get; set; }
        public string bio { get; set; }
        public string website { get; set; }
        public string is_business { get; set; }
        public Count counts { get; set; }
    }
}
