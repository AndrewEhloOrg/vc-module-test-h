angular.module('AndrewEhloOrg.TestH')
    .controller('AndrewEhloOrg.TestH.helloWorldController', ['$scope', 'AndrewEhloOrg.TestH.webApi', function ($scope, api) {
        var blade = $scope.blade;
        blade.title = 'TestH';

        blade.refresh = function () {
            api.get(function (data) {
                blade.title = 'TestH.blades.hello-world.title';
                blade.data = data.result;
                blade.isLoading = false;
            });
        };

        blade.refresh();
    }]);
