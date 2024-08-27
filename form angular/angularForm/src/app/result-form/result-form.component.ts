import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-result-form',
  templateUrl: './result-form.component.html',
  styleUrls: ['./result-form.component.css']
})
export class ResultFormComponent implements OnInit {

  finalData: any;
  constructor(
    private router: Router
  ) { }
  ngOnInit(): void {
    console.log(window.history.state)
    this.finalData = window.history.state
  }
  navtoCreateForm(){
    this.router.navigate(['/create'],{})
  }
}
