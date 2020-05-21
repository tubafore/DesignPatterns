using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class TwitterService
    {
        private readonly string appKey;
        private readonly string appSecret;

        public TwitterService(string appKey, string appSecret)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
        }

        public List<Tweet> GetLatestTweets() 
        {
            string accessToken = Connect();
            TwitterClient client = new TwitterClient();
            return client.GetRecentTweets(accessToken);
        }

        private string Connect()
        {
            OAuth oAuth = new OAuth();
            return oAuth.GetAccessToken(oAuth.RequestToken(appKey, appSecret));
        }
    }
}
