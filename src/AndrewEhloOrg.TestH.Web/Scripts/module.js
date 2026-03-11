// Call this to register your module to main application
var moduleName = 'AndrewEhloOrg.TestH';

if (AppDependencies !== undefined) {
    AppDependencies.push(moduleName);
}

angular.module(moduleName, [])
    .config(['$stateProvider',
        function ($stateProvider) {
            $stateProvider
                .state('workspace.TestHState', {
                    url: '/test-h',
                    templateUrl: '$(Platform)/Scripts/common/templates/home.tpl.html',
                    controller: [
                        'platformWebApp.bladeNavigationService',
                        function (bladeNavigationService) {
                            var newBlade = {
                                id: 'blade1',
                                controller: 'AndrewEhloOrg.TestH.helloWorldController',
                                template: 'Modules/$(AndrewEhloOrg.TestH)/Scripts/blades/hello-world.html',
                                isClosingDisabled: true,
                            };
                            bladeNavigationService.showBlade(newBlade);
                        }
                    ]
                });
        }
    ])
    .run(['platformWebApp.mainMenuService', '$state',
        function (mainMenuService, $state) {
            //Register module in main menu
            var menuItem = {
                path: 'browse/test-h',
                icon: 'fa fa-cube',
                title: 'TestH',
                priority: 100,
                action: function () { $state.go('workspace.TestHState'); },
                permission: 'test-h:access',
            };
            mainMenuService.addMenuItem(menuItem);
        }
    ]);
