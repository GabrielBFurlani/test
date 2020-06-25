﻿(function () {

    angular.module("app").controller('clientDetailController', ['$scope', '$state', '$http', 'CONFIG', '$stateParams', '$uibModal', function ($scope, $state, $http, CONFIG, $stateParams, $uibModal) {
        var _apiUrl = CONFIG.apiRootUrl;
        var id = $stateParams.idProcess;

        $scope.client = {};

        if ($scope.id == 1) {
            $scope.client = { name: 'João Antonio', cpf: '78803885161', cnpj: '38042126000100', id: 1 };
        }
        else {
            $scope.client = { name: 'Pedro Dotaviano', cpf: '62311649850', cnpj: '33983543000125', id: 2 };
        }

        //Load Page
        function loadPage() {
            /*
            $http.get(_apiUrl + '/profile/all')
                .then(function successCallback(response) {
                    $scope.profiles = response.data.resultData;
                });*/

            //Check if its update operation
            if (id != 0) {
                /*
                //get data
                $http.get(_apiUrl + '/user/management/' + id)
                    .then(function successCallback(response) {

                        $scope.user = response.data.resultData;

                        //checks if the user has photo
                        if ($scope.user.photo) {
                            $scope.hasPhoto = true;
                        }
                        else {
                            $scope.hasPhoto = false;
                        }
                    });*/
            }
        }

        //Button: Edit User
        $scope.edit = function (id) {
            //$state.go('panel.user.management.edit', { idUser: id });


            //open modal
            var modalInstance = $uibModal.open({
                templateUrl: 'app/panel/client/modals/accept-client.html',
                controller: 'acceptClientController'
            });

        };

        //Button: Save
        $scope.save = function () {

        }

        //Button: Back
        $scope.back = function () {
            $state.go("panel.client.list");
        }

        //procedural script
        loadPage();

    }]);
}());