import {bootstrap} from 'angular2/platform/browser'
import {HTTP_PROVIDERS} from 'angular2/http';
import {HttpService} from './httpService';
import 'rxjs/Rx';
import {AppComponent} from './app';

bootstrap(AppComponent, [HTTP_PROVIDERS, HttpService]);