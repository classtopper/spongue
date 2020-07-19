/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.paymentNganLuong', [])
        .config(['$stateProvider',
            function ($stateProvider) {
                $stateProvider
                    .state('payments-nganluong-config', {
                        url: '/payments/ngan-luong/config',
                        templateUrl: '_content/Spongue.Module.PaymentNganLuong/admin/ngan-luong/ngan-luong-config-form.html',
                        controller: 'NganLuongConfigFormCtrl as vm'
                    })
                ;
            }
        ]);
})();
