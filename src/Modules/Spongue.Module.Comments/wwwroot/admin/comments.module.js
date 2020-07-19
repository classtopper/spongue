/*global angular*/
(function () {
    'use strict';

    angular
        .module('spongueAdmin.comments', [])
        .config(['$stateProvider',
            function ($stateProvider) {
                $stateProvider
                    .state('comments', {
                        url: '/comments',
                        templateUrl: '_content/Spongue.Module.Comments/admin/comment/comment-list.html',
                        controller: 'CommentListCtrl as vm'
                    })
                ;
            }
        ]);
})();
