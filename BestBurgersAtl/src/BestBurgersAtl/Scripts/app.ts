///<reference path="../node_modules/angular2/typings/browser.d.ts"/>
import {Component} from 'angular2/core';
import {Injectable} from 'angular2/core';
import {CORE_DIRECTIVES} from 'angular2/common';
import {Observable}     from 'rxjs/Observable';
import 'rxjs/add/operator/map';

////private services
import {HttpService} from './httpService';
import {Post} from './post';

@Component({
    selector: 'my-app',
    templateUrl: 'home.html',
    providers: [HttpService],
    directives: [CORE_DIRECTIVES]
    //template: 'New text that is different'
})

export class AppComponent {
    posts: Array<Post> [];

    constructor(public httpService: HttpService) {
        var json: any;
        httpService.get('posts')
            .subscribe(res => 
                this.posts = res.json());
        console.log('json', this.posts);
        //var postsTmp = JSON.parse(json);
    }
}