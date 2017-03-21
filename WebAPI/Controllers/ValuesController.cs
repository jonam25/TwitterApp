using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            private static string accessToken = "75138075-VngzNX3iGJAUnbL8UvFQGxghHSUJxlWwfe6Y26F2K";
            private static string accessTokenSecret = "blPMN1HHyF4qFnEqARuzz6V7vGzqk0uwyMrDa1gwAGwH8";
            private static string consumerKey = "GMgdfCglEZbtFX8j6eRGxQHTN";
            private static string consumerSecret = "kyeDUGzwNnIqdwEge65oyDpLykqrxS0Svh81AAf7Rf04OOjVzw";
            private static string twitterAcccountToDisplay = "jonam25";
            private static string searchTweet = "EVMkaBahana";
            private static int tweetCount=10;
            
            var authorizer = new SingleUserAuthorizer
            {

                CredentialStore = new InMemoryCredentialStore()
                {
                    ConsumerKey = "GMgdfCglEZbtFX8j6eRGxQHTN", //consumerKey,
                    ConsumerSecret = "kyeDUGzwNnIqdwEge65oyDpLykqrxS0Svh81AAf7Rf04OOjVzw", //consumerSecret,
                    OAuthToken = "75138075-VngzNX3iGJAUnbL8UvFQGxghHSUJxlWwfe6Y26F2K", //accessToken,
                    OAuthTokenSecret = "blPMN1HHyF4qFnEqARuzz6V7vGzqk0uwyMrDa1gwAGwH8", //accessTokenSecret,
                    ScreenName = "jonam25", //twitterAcccountToDisplay,
                    UserID = 66370920
                }
            };

            var twitterContext = new TwitterContext(authorizer);
            List<Search> statusTweets = new List<Search>();
            try
            {
                statusTweets = (from tweet in twitterContext.Search
                                where tweet.Type == SearchType.Search && tweet.Query == searchTweet
                                && tweet.Count == tweetCount
                                && tweet.ResultType == ResultType.Popular
                                select tweet).ToList();
             }
            catch (AggregateException e)
            {

                Console.WriteLine("AggregateException {0}", e.InnerExceptions[0]);

            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
