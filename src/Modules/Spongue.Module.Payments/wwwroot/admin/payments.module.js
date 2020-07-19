/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.payments', [])
        .config(['$stateProvider', function ($stateProvider) {
            $stateProvider.state('payment-providers', {
                url: '/payment-providers',
                templateUrl: "_content/Spongue.Module.Payments/admin/provider/payment-provider-list.html",
                controller: 'PaymentProviderListCtrl as vm'
            });
        }]);
})();
