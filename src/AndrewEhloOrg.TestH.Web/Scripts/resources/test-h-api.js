angular.module('AndrewEhloOrg.TestH')
    .factory('AndrewEhloOrg.TestH.webApi', ['$resource', function ($resource) {
        return $resource('api/test-h');
    }]);
