// openweather.service.ts
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, forkJoin } from 'rxjs';

@Injectable({
 providedIn: 'root'
})
export class OpenweatherService {

 private apiUrl = 'http://api.openweathermap.org/data/2.5/weather';
 private apiKey = '5ff40ca859b72d9abb4aefdc5ecfb294';
 private apurl = 'http://api.openweathermap.org/data/2.5/air_pollution';

 constructor(private http: HttpClient) { }

 getWeather(city: string): Observable<any>  {
    return this.http.get(`${this.apiUrl}?q=${city}&units=Metric&appid=${this.apiKey}`);
 }
 getAirQuality(lat : any,lon : any): Observable<any> {
    return this.http.get(`${this.apurl}?lat=${lat}&lon=${lon}&appid=${this.apiKey}`)
 } 
}