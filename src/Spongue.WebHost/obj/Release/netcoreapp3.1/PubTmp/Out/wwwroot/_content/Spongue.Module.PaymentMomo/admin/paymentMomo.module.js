/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.paymentMomo', [])
        .config(['$stateProvider',
            function ($stateProvider) {
                $stateProvider
                    .state('payments-momo-config', {
                        url: '/payments/momo/config',
                        templateUrl: '_content/Spongue.Module.PaymentMomo/admin/momo/momo-config-form.html',
                        controller: 'MomoConfigFormCtrl as vm'
                    })
                ;
            }
        ]);
})();
