import { Injectable } from '@angular/core';
import { resolve } from 'dns';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor() { }
  login(): Promise<any> {
    return new Promise((resolve)=> {
      localStorage.setItem('loggedIn','true');
      resolve(true);
    })
  }
  isLoggedin() : boolean {
    return !!localStorage.getItem('loggedIn');
  }
}
