/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.vendors', [])
        .config(['$stateProvider', function ($stateProvider) {
            $stateProvider.state('vendors', {
                url: '/vendors',
                templateUrl: "_content/Spongue.Module.Vendors/admin/vendors/vendor-list.html",
                controller: 'VendorListCtrl as vm'
            })
            .state('vendor-create', {
                url: '/vendors/create',
                templateUrl: "_content/Spongue.Module.Vendors/admin/vendors/vendor-form.html",
                controller: 'VendorFormCtrl as vm'
            })
            .state('vendor-edit', {
                url: '/vendors/edit/:id',
                templateUrl: '_content/Spongue.Module.Vendors/admin/vendors/vendor-form.html',
                controller: 'VendorFormCtrl as vm'
            });
        }]);
})();
