import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OpenweatherService } from '../openweather.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent implements OnInit {
  role:any;
  weather:any;
  imageurl = '';
  form!: FormGroup;
  airquality:any;
  constructor(
    private router: Router,
    private openweatherService:OpenweatherService,
    private fb:FormBuilder,
    
  ) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      country:[[],Validators.required]
    })
    console.log(window.history.state)
    this.role = window.history.state
    console.log(localStorage.getItem('role'))
    document.body.style.backgroundColor = "white";
    document.getElementById("navbar")!.style.opacity = "1";
    document.getElementById("container")!.style.opacity="1";
    document.getElementById("banner")!.style.opacity="1";
  }
  getweatherbycityname() {
    this.openweatherService.getWeather(this.form.get('country')?.value).subscribe(data => {
      this.weather = data;
      // console.log(this.weather.coord.lat);
      var iconcode = this.weather.weather[0].icon;
      this.imageurl = "http://openweathermap.org/img/w/" + iconcode + ".png";
      this.openweatherService.getAirQuality(this.weather.coord.lat,this.weather.coord.lat).subscribe(AQdata => {
        this.airquality = AQdata;
        var aqi = this.airquality.list[0].main.aqi
        console.log(aqi);
        switch (aqi) {
          case 1 :
            document.getElementById("bar")!.style.width = "20%";
            break;
          case 2 :
            document.getElementById("bar")!.style.width = "40%"
            break;
          case 3 :
            document.getElementById("bar")!.style.width = "60%"
            break;
          case 4 :
            document.getElementById("bar")!.style.width = "80%"
            break;
          case 5 :
            document.getElementById("bar")!.style.width = "100%"
            break;
          
        }

      })
  
      
    });

  }
  logout() {
    localStorage.removeItem('loggedIn');
    this.router.navigate(["/login"])
  }
  openNav() {
    let element = document.getElementById("mySidenav") 
    if(element){
      let style = element?.style
      style!.width = "250px";
      document.body.style.backgroundColor = "rgba(0, 0, 0, 0.2)";
      document.getElementById("navbar")!.style.opacity = "0.5";
      document.getElementById("container")!.style.opacity="0.5";
      document.getElementById("banner")!.style.opacity="0.5";
    }

  }
  signout(){
    localStorage.clear();
    this.router.navigate(["/login"])
  }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
  closeNav() {
    let element = document.getElementById("mySidenav") 
    if(element){
      let style = element?.style
      style!.width = "0px";
      document.body.style.backgroundColor = "white";
      document.getElementById("navbar")!.style.opacity = "1";
      document.getElementById("container")!.style.opacity="1";
      document.getElementById("banner")!.style.opacity="1";
    }

  }
}
