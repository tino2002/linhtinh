import { Component, OnInit } from '@angular/core';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-create-account',
  templateUrl: './create-account.component.html',
  styleUrls: ['./create-account.component.css']
})
export class CreateAccountComponent implements OnInit {

  constructor(
    private router : Router
  ) { }

  ngOnInit(): void {
  }
  navtoLoginForm(){
    this.router.navigate(['/login'])
  }
}
