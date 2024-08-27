import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Route, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from './auth.service';


@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  
  constructor(private auth:AuthService, private router: Router){}
  
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      const { routeConfig } = route; 
      const { path } = routeConfig as Route; 
      const usersrole = localStorage.getItem('role');
      if (usersrole === 'admin') {
        return true;
      } else {
        this.router.navigate(['/login']);
        return false;
      }
 
}
}
