/*global angular*/
(function () {
    angular
        .module('spongueAdmin.paymentCoD')
        .factory('paymentCoDService', ['$http', paymentCoDService]);

    function paymentCoDService($http) {
        var service = {
            getSettings: getSettings,
            updateSetting: updateSetting
        };
        return service;

        function getSettings() {
            return $http.get('api/cod/config');
        }

        function updateSetting(settings) {
            return $http.put('api/cod/config', settings);
        }
    }
})();
