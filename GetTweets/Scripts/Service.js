app.service("TweetService", function ($http) {
    this.getTweets = function () {
        debugger;
        return $http.get("/Tweet/Tweets");
    };
});