System.register(['angular2/core', 'angular2/common', 'rxjs/add/operator/map', './httpService'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var core_1, common_1, httpService_1;
    var AppComponent;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (common_1_1) {
                common_1 = common_1_1;
            },
            function (_1) {},
            function (httpService_1_1) {
                httpService_1 = httpService_1_1;
            }],
        execute: function() {
            AppComponent = (function () {
                function AppComponent(httpService) {
                    var _this = this;
                    this.httpService = httpService;
                    var json;
                    httpService.get('posts')
                        .subscribe(function (res) {
                        return _this.posts = res.json();
                    });
                    console.log('json', this.posts);
                    //var postsTmp = JSON.parse(json);
                }
                AppComponent.prototype.ngOnInit = function () {
                    var windowHeight = $(window).height();
                    var navButtonHeight = $("#nav-button").height();
                    var fontSize = parseInt($("body").css("font-size"));
                    $('#nav-button-container').sticky({ topSpacing: windowHeight - navButtonHeight - (2 * fontSize), center: true });
                };
                AppComponent.prototype.getDate = function (date) {
                    console.log(date);
                    return moment(date).format('MMM YY');
                };
                AppComponent = __decorate([
                    core_1.Component({
                        selector: 'my-app',
                        templateUrl: 'home.html',
                        providers: [httpService_1.HttpService],
                        directives: [common_1.CORE_DIRECTIVES]
                    }), 
                    __metadata('design:paramtypes', [httpService_1.HttpService])
                ], AppComponent);
                return AppComponent;
            }());
            exports_1("AppComponent", AppComponent);
        }
    }
});
//# sourceMappingURL=app.js.map