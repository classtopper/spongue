/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.pricing', [])
        .config(['$stateProvider',
            function ($stateProvider) {
                $stateProvider
                    .state('cart-rules', {
                        url: '/cart-rules',
                        templateUrl: '_content/Spongue.Module.Pricing/admin/cart-rule/cart-rule-list.html',
                        controller: 'CartRuleListCtrl as vm'
                    })
                    .state('cart-rule-create', {
                        url: '/cart-rule/create',
                        templateUrl: '_content/Spongue.Module.Pricing/admin/cart-rule/cart-rule-form.html',
                        controller: 'CartRuleFormCtrl as vm'
                    })
                    .state('cart-rule-edit', {
                        url: '/cart-rule/edit/:id',
                        templateUrl: '_content/Spongue.Module.Pricing/admin/cart-rule/cart-rule-form.html',
                        controller: 'CartRuleFormCtrl as vm'
                    })
                    .state('cart-rule-usages', {
                        url: '/cart-rule-usages',
                        templateUrl: '_content/Spongue.Module.Pricing/admin/cart-rule-usage/cart-rule-usage-list.html',
                        controller: 'CartRuleUsageListCtrl as vm'
                    })
                ;
            }
        ]);
})();
