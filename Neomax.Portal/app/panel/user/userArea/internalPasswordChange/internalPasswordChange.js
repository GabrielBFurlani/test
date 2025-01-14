﻿(function () {

    angular.module("app").controller('internalPasswordChangeController', ['$scope', '$state', '$http', 'CONFIG', '$stateParams', 'userControl', function ($scope, $state, $http, CONFIG, $stateParams, userControl) {
        var _apiUrl = CONFIG.apiRootUrl;

        $scope.changeInfo = {
            idUser: userControl.userSession.idUser,
            newPassword: '',
            changePasswordToken: null
        };

        $scope.reEnterPassword = '';

        //Button: OK
        $scope.ok = function () {

            $http.post(_apiUrl + '/user/userArea/internalPasswordChange', $scope.changeInfo)
                .then(function successCallback(response) {
                    $state.go('panel.home');
                })
        };

    }]);
}());