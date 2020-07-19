/*global angular*/
(function () {
    angular
        .module('spongueAdmin.payments')
        .factory('paymentService', ['$http', paymentService]);

    function paymentService($http) {
        var service = {
            getPaymentsByOrder: getPaymentsByOrder
        };
        return service;

        function getPaymentsByOrder(orderId) {
            return $http.get('api/orders/' + orderId + '/payments');
        }
    }
})();
