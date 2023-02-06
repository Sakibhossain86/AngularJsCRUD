angular.module("demoApp")
    .factory("dataService", $http => {
        return {
            get: function (url) {
                return $http.get(url);
            },
            post: function (url, data) {
                console.log(data);
                return $http.post(url, data);
            }
        };
       
    });