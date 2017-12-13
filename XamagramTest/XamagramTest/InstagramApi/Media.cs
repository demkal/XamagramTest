using System;
using System.Collections.Generic;
using System.Text;

namespace XamagramTest.InstagramApi
{
    public class Media
    {
        public MediaType type { get; set; }
        // User in photo may not be needed for my app 
        // public List<User> users_in_photo { get; set; }
        public string filter { get; set; }
        public List<string> tags { get; set; }
        public Comments comments { get; set; }
        public string caption { get; set; }
        public List<User> likes { get; set; }
        public string link { get; set; }
        public User user { get; set; }
        public DateTime created_time { get; set; }

        // TODO : Create the collection of images
        // TODO : Create the collection of videos
        // TODO : Created the collection of carousel

        public long id { get; set; }
        // TODO : location might be an object, 
        public string location { get; set; }
    }
}
