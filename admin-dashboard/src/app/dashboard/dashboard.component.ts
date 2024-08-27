import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  role:any;
  constructor(
    private router: Router
  ) { }
  
  ngOnInit(): void {
    console.log(window.history.state)
    this.role = window.history.state
    console.log(localStorage.getItem('role'))
    document.body.style.backgroundColor = "white";
    document.getElementById("navbar")!.style.opacity = "1";
    document.getElementById("container")!.style.opacity="1";
    document.getElementById("banner")!.style.opacity="1";
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
  navtoweather() {
    this.router.navigate(["/weather"])
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
