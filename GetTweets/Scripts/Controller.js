app.controller("TweetCtrl", function ($scope, TweetService) {
    GetAllTweets();

    function GetAllTweets() {
        debugger;
        var getAllTweets = TweetService.getTweets();
        getAllTweets.then(function (tvm) {
            $scope.tweets = tvm.data;
        }, function () {
            alert('Data not found');
        });
    }
});