angular.module("demoApp")
    .controller("memberCtrl", ($scope, dataService) => {
        $scope.modelError = "";
        $scope.memberObj = {};
        dataService.get("/api/Members")
            .then(r => {
                console.log(r)
                $scope.model.members = r.data;
                //console.log($scope.model)
            }, err => {
                console.log(err);
            });
       /* dataService.get(`/thana/Members``)
            .then(r => {
                console.log(r)
                $scope.model.members = r.data;
                //console.log($scope.model)
            }, err => {
                console.log(err);
            });*/
        $scope.getGenderName = value => {
            //console.log(value)
            return Number(value) == 0 ? "Male" : "Female";
        }
        $scope.getThana = district => {
            console.log(district)
            dataService.get(`/thana/${district}`)
            .then(r => {
                console.log(r)
                $scope.model.thanaList = r.data;
                console.log($scope.model)
            }, err => {
                console.log(err);
            });
        }
        $scope.insertMember = () => {
            console.log($scope.memberObj)
            dataService.post("/api/Members", $scope.memberObj)
                .then(r => {
                    console.log(r);
                    $scope.model.members.push(r.data);
                    $scope.memberObj = {};
                }, err => {
                    console.log(err);
                })
        }
    });