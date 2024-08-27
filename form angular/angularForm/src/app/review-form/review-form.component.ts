import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Route } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-review-form',
  templateUrl: './review-form.component.html',
  styleUrls: ['./review-form.component.css']
})
export class ReviewFormComponent implements OnInit {

  formData: any;
  constructor(
    private router: Router
  ) { }
  ngOnInit(): void {
    console.log(window.history.state)
    this.formData = window.history.state
  }
  navtoCreateForm(){
    this.router.navigate(['/create'],{})
  }
  navtoResultForm(){
    this.router.navigate(['/result'],{state: this.formData})
  }
}
