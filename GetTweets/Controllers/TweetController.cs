using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Web.Script.Serialization;
using LinqToTwitter;
using Newtonsoft.Json;
using GetTweets.ViewModel;
using Models;

namespace GetTweets.Controllers
{
    public class TweetController : Controller
    {
        private static string searchTweet = "#DWTS";
        private static Int64 tweetCount = 10;
        public JsonResult Tweets(Tweet t)
        {          

            var authorizer = new SingleUserAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore()
                {
                    ConsumerKey = ConfigurationManager.AppSettings["ConsumerKey"],
                    ConsumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"],
                    OAuthToken = ConfigurationManager.AppSettings["OAuthToken"],
                    OAuthTokenSecret = ConfigurationManager.AppSettings["OAuthTokenSecret"],
                    ScreenName= ConfigurationManager.AppSettings["ScreenName"],
                    UserID = Convert.ToUInt64(ConfigurationManager.AppSettings["UserID"])                
                }
            };

            var twitterContext = new TwitterContext(authorizer);
            List<Search> statusTweets = new List<Search>();
          
            statusTweets = (from tweet in twitterContext.Search
                                where tweet.Type == SearchType.Search && tweet.Query == searchTweet
                                && tweet.Count == tweetCount
                                && tweet.ResultType == ResultType.Popular
                                select tweet).ToList();
            
            var json = JsonConvert.SerializeObject(new
            {
                operations = statusTweets
            });
            
            var result= Json(json, JsonRequestBehavior.AllowGet);
            var root = new JavaScriptSerializer().Deserialize<RootObject>(result.Data.ToString());
            var ops = root.operations.FirstOrDefault();

            TweetViewModel tvm = new TweetViewModel();
            tvm.tweet = new Tweet() { Message=ops.Query };
            tvm.tweets = new List<Tweet>();

            foreach (var status in ops.Statuses)
            {                
                Tweet twt = new Tweet();
                twt.Message = status.Text;
                twt.LikesCount = status.FavoriteCount;
                twt.TimePosted = status.CreatedAt;
                twt.RetweetCount = status.RetweetCount;
                twt.Author = status.User.Name;
                twt.AuthorPic = status.User.ProfileImageUrl;
                tvm.tweets.Add(twt);
            }
            return Json(tvm, JsonRequestBehavior.AllowGet);            
        }

        public ActionResult Tweet1()
        {           
            var authorizer = new SingleUserAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore()
                {
                    ConsumerKey = ConfigurationManager.AppSettings["ConsumerKey"],
                    ConsumerSecret = ConfigurationManager.AppSettings["ConsumerSecret"],
                    OAuthToken = ConfigurationManager.AppSettings["OAuthToken"],
                    OAuthTokenSecret = ConfigurationManager.AppSettings["OAuthTokenSecret"],
                    ScreenName = ConfigurationManager.AppSettings["ScreenName"],
                    UserID = Convert.ToUInt64(ConfigurationManager.AppSettings["UserID"])
                }
            };

            var twitterContext = new TwitterContext(authorizer);
            List<Search> statusTweets = new List<Search>();

            
        statusTweets = (from tweet in twitterContext.Search
                            where tweet.Type == SearchType.Search && tweet.Query == searchTweet
                            && tweet.Count == tweetCount
                            && tweet.ResultType == ResultType.Popular
                            select tweet).ToList();

            var json = JsonConvert.SerializeObject(new
            {
                operations = statusTweets
            });

            var result = Json(json, JsonRequestBehavior.AllowGet);
            var root = new JavaScriptSerializer().Deserialize<RootObject>(result.Data.ToString());
            var ops = root.operations.FirstOrDefault();

            TweetViewModel tvm = new TweetViewModel();
            tvm.tweet = new Tweet() { Message = ops.Query };
            tvm.tweets = new List<Tweet>();

            foreach (var status in ops.Statuses)
            {
                Tweet twt = new Tweet();
                twt.Message = status.Text;
                twt.LikesCount = status.FavoriteCount;
                twt.TimePosted = status.CreatedAt;
                twt.RetweetCount = status.RetweetCount;
                twt.Author = status.User.Name;
                twt.AuthorPic = status.User.ProfileImageUrl;
                tvm.tweets.Add(twt);
            }
            return View(tvm);
        }

        public ActionResult Home()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

    }
}