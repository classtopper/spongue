/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.dashboard', [])
        .config(['$stateProvider', function ($stateProvider) {
            $stateProvider.state('dashboard', {
                url: '/dashboard',
                templateUrl: "/admin/dashboard-tpl"
            });
        }]);
})();