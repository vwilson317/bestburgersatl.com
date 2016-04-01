///<reference path="../node_modules/angular2/typings/browser.d.ts"/>
import {Component, Injectable, OnInit} from 'angular2/core';
import {CORE_DIRECTIVES} from 'angular2/common';
import {Observable}     from 'rxjs/Observable';
import 'rxjs/add/operator/map';

////private services
import {HttpService} from './httpService';
import {Post} from './post';

declare var moment: any;
declare var $: any;

@Component({
    selector: 'my-app',
    templateUrl: 'home.html',
    providers: [HttpService],
    directives: [CORE_DIRECTIVES]
    //template: 'New text that is different'
})

export class AppComponent implements OnInit {
    posts: Array<Post> [];

    constructor(public httpService: HttpService) {
        var json: any;
        httpService.get('posts')
            .subscribe(res => 
                this.posts = res.json());
        console.log('json', this.posts);
        //var postsTmp = JSON.parse(json);
    }

    ngOnInit() {
        var windowHeight = $(window).height();
        var navButtonHeight = $("#nav-button").height();
        var fontSize = parseInt($("body").css("font-size"));
        $('#nav-button-container').sticky({ topSpacing: windowHeight - navButtonHeight - (2 * fontSize), center: true });
    }

    getDate(date: string) {
        console.log(date);
        return moment(date).format('MMM YY');
    }
}