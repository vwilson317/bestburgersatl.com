System.register(['angular2/platform/browser', 'angular2/http', './httpService', 'rxjs/Rx', './app'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var browser_1, http_1, httpService_1, app_1;
    return {
        setters:[
            function (browser_1_1) {
                browser_1 = browser_1_1;
            },
            function (http_1_1) {
                http_1 = http_1_1;
            },
            function (httpService_1_1) {
                httpService_1 = httpService_1_1;
            },
            function (_1) {},
            function (app_1_1) {
                app_1 = app_1_1;
            }],
        execute: function() {
            browser_1.bootstrap(app_1.AppComponent, [http_1.HTTP_PROVIDERS, httpService_1.HttpService]);
        }
    }
});
//# sourceMappingURL=boot.js.map