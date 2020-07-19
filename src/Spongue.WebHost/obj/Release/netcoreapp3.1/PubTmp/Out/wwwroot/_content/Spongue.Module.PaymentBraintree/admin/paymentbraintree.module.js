/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.paymentBraintree', [])
        .config(['$stateProvider',
            function ($stateProvider) {
                $stateProvider
                    .state('payments-braintree-config', {
                        url: '/payments/braintree/config',
                        templateUrl: '_content/Spongue.Module.PaymentBraintree/admin/braintree/braintree-config-form.html',
                        controller: 'BraintreeConfigFormCtrl as vm'
                    })
                ;
            }
        ]);
})();
