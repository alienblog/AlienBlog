(function () {
    var controllerId = 'app.views.home';
    var tagServiceId = 'abp.services.app.tag';
    angular.module('app').controller(controllerId, [
        '$scope', tagServiceId, function ($scope, tagService) {
            var vm = this;
            //Home logic...
            tagService.getTags();
        }
    ]);
})();