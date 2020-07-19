/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.paymentStripe', [])
        .config(['$stateProvider',
            function ($stateProvider) {
                $stateProvider
                    .state('payments-stripe-config', {
                        url: '/payments/stripe/config',
                        templateUrl: '_content/Spongue.Module.PaymentStripe/admin/stripe/stripe-config-form.html',
                        controller: 'StripeConfigFormCtrl as vm'
                    })
                ;
            }
        ]);
})();
