import { Injectable } from '@angular/core';
import { RouteReuseStrategy, DetachedRouteHandle, ActivatedRouteSnapshot } from '@angular/router';

@Injectable({
 providedIn: 'root'
})
export class CustomReuseStrategyService implements RouteReuseStrategy {

 private handlers: { [key: string]: DetachedRouteHandle } = {};

 shouldDetach(route: ActivatedRouteSnapshot): boolean {
   return route.data['shouldReuse'] || false;
 }

 store(route: ActivatedRouteSnapshot, handle: DetachedRouteHandle): void {
   this.handlers[route?.routeConfig?.path ?? 0] = handle;
 }

 shouldAttach(route: ActivatedRouteSnapshot): boolean {
   return !!this.handlers[route?.routeConfig?.path ?? 0];
 }

 retrieve(route: ActivatedRouteSnapshot): DetachedRouteHandle {
   return this.handlers[route?.routeConfig?.path ?? 0];
 }

 shouldReuseRoute(future: ActivatedRouteSnapshot, curr: ActivatedRouteSnapshot): boolean {
   return future.routeConfig === curr.routeConfig;
 }
}