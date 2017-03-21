function TweetViewModel($scope, $http) {    
    $scope.Tweet = {
        "TweetHashTag": "",
        "Message": "",
        "Author": "",
        "AuthorPic": "",
        "TimePosted": "",
        "RetweetCount": 0,
        "LikesCount": 0
    };
    $scope.Tweets = {};
    $scope.LoadByTag = function () {
        $http({
            method: "POST",
            data: $scope.Tweet,
            url: "Tweets"
        }).
    success(function (data, status, headers, config) {
        $scope.Tweets = data;

    });
    }

}