import { Component , OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import {AbstractControl, ValidationErrors, ValidatorFn, FormControl} from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../auth.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  redirectUrl : any = '';
  form!: FormGroup;
  usnvalue : any;
  pswvalue : any;
  role = "admin"
  constructor(
    private fb: FormBuilder,
    private router: Router,
    private auth: AuthService,
    private activatedRoute : ActivatedRoute
  ) { }

  ngOnInit(): void {
    console.log(localStorage.getItem("role"))
    this.form = this.fb.group({
      usni: ['',[Validators.required]],
      pswi: ['',[Validators.required]],
    })
  }
  navtoCreateForm(){
    this.router.navigate(['/create'])
  }
  navtoFotgotForm(){
    this.router.navigate(['/forgotpassword'])
  }
  navtoDasboard(){
    this.usnvalue = this.form.get('usni')?.value;
    this.pswvalue = this.form.get('pswi')?.value;
    this.router.navigate(['/dashboard'])
    if (this.usnvalue == "admin" && this.pswvalue == "123456") {
      localStorage.setItem('role',this.role)
      console.log(this.form.value)
      this.router.navigate(['/dashboard'])
    }
    // this.router.navigate(['/dashboard'],{state:{'role': this.role}})
    

  }
}
