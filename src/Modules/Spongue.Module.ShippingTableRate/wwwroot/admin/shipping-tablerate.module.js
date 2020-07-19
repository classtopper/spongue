/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.shipping-tablerate', [])
        .config(['$stateProvider', function ($stateProvider) {
            $stateProvider.state('shipping-table-rate-config', {
                url: '/shippings/table-rate-config',
                templateUrl: "_content/Spongue.Module.ShippingTableRate/admin/tablerate/shipping-tablerate-form.html",
                controller: 'ShippingTableRateFormCtrl as vm'
            });
        }]);
})();
