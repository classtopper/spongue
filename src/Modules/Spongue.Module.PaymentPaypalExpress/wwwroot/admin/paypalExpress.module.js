/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.paymentPaypalExpress', [])
        .config(['$stateProvider',
            function ($stateProvider) {
                $stateProvider
                    .state('payments-paypalExpress-config', {
                        url: '/payments/paypal-express/config',
                        templateUrl: '_content/Spongue.Module.PaymentPaypalExpress/admin/config/config-form.html',
                        controller: 'PaypalExpressConfigFormCtrl as vm'
                    })
                    ;
            }
        ]);
})();
