/*global angular*/
(function () {
    angular
        .module('spongueAdmin.catalog')
        .factory('spongueProductWidgetService', ['$http', spongueProductWidgetService]);

    /* @ngInject */
    function spongueProductWidgetService($http) {
        var service = {
            getWidgetZones: getWidgetZones,
            getSpongueProductWidget: getSpongueProductWidget,
            createSpongueProductWidget: createSpongueProductWidget,
            editSpongueProductWidget: editSpongueProductWidget
        };

        return service;

        function getWidgetZones() {
            return $http.get('api/widget-zones');
        }

        function getSpongueProductWidget(id) {
            return $http.get('api/spongue-product-widgets/' + id);
        }
        
        function createSpongueProductWidget(widgetInstance) {
            return $http.post('api/spongue-product-widgets', widgetInstance);
        }

        function editSpongueProductWidget(widgetInstance) {
            return $http.put('api/spongue-product-widgets/' + widgetInstance.id, widgetInstance);
        }
    }
})();
