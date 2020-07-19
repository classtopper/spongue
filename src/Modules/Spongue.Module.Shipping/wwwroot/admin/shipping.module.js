/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.shippings', [])
        .config(['$stateProvider', function ($stateProvider) {
            $stateProvider.state('shipping-providers', {
                url: '/shipping-providers',
                templateUrl: "_content/Spongue.Module.Shipping/admin/provider/shipping-provider-list.html",
                controller: 'ShippingProviderListCtrl as vm'
            });
        }]);
})();
