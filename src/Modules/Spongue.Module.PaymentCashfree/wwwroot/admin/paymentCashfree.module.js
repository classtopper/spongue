/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.paymentCashfree', [])
        .config(['$stateProvider',
            function ($stateProvider) {
                $stateProvider
                    .state('payments-cashfree-config', {
                        url: '/payments/cashfree/config',
                        templateUrl: '_content/Spongue.Module.PaymentCashfree/admin/cashfree/cashfree-config-form.html',
                        controller: 'CashfreeConfigFormCtrl as vm'
                    })
                ;
            }
        ]);
})();
