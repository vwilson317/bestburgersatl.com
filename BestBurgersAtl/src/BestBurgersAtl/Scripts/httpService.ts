import {Injectable} from 'angular2/core';
import {Http, Response, Request, HTTP_PROVIDERS} from 'angular2/http';

@Injectable()
export class HttpService {
    data = Object;

    constructor(public http: Http) {
        console.log('Http Service created.', http);
    }

    get(resource: string) {
        console.log('Get called with.', resource);
        return this.http.get('api/' + resource)
        .map(response => (<Response>response));
    };
}
