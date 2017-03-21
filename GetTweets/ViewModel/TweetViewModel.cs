using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace GetTweets.ViewModel
{
    public class TweetViewModel
    {
        public Tweet tweet { get; set; }
        public List<Tweet> tweets { get; set; }
    }

  
}