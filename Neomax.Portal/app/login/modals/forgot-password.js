﻿(function () {
    "use strict";

    angular.module('app').controller('forgotPasswordController', ['$scope', '$http', 'CONFIG', '$uibModalInstance', function ($scope, $http, CONFIG, $uibModalInstance) {
        var _apiUrl = CONFIG.apiRootUrl;

        function loadPage() {
            $scope.email = "";
        }
        
        $scope.cancel = function () {
            $uibModalInstance.dismiss();
        }

        $scope.send = function () {

            $http.post(_apiUrl + '/user/forgotPassword/' + $scope.email + '/')
                .then(function successCallback(response) {

                    //Closes the modal
                    $uibModalInstance.close();
                })
        }

        loadPage();

    }]);
}());