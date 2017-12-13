using System;
using System.Collections.Generic;
using System.Text;

namespace XamagramTest.InstagramApi
{
    public class Comment
    {
        public DateTime created_time { get; set; }
        public string text { get; set; }
        public User from { get; set; }
        public string id { get; set; }
    }
}
