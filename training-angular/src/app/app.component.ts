import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import {AbstractControl, ValidationErrors, ValidatorFn} from '@angular/forms';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'training-angular';
  form!: FormGroup;
  submited = false;
  error = '';

  constructor(
    private fb: FormBuilder,

  ) {}

  ngOnInit(): void {
    
    this.form = this.fb.group({
      user: ['', [ Validators.required,Validators.minLength(6), Validators.maxLength(30),Validators.pattern(/^[a-z]{6,32}$/i)]],
      pass: ['', [Validators.required,this.passwordValidator()]],
      
    })
  }

  checkValid() {
    // this.form.get('user')
    if (this.form.controls['user'].value == '' ){
      console.log("field is required")
      this.error = "field is required"
    }
  }

  getControl(name: string){
    return this.form.controls[name];
  }
  showError(controlName: string): Boolean {
    const control = this.getControl(controlName)
     return Boolean(control.invalid)
  }
  onSubmit() {

    console.log(this.form.value);

    this.submited = true;
    this.form.markAllAsTouched()
  }

  passwordValidator(): ValidatorFn {
    return (control:AbstractControl) : ValidationErrors | null => {
        console.log('first')
        const value = control.value;
        if (!value) {
            return null;
        }
        const hasSpecialCharacter = /[!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?]/.test(value);
        const hasUpperCase = /[A-Z]+/.test(value);
        const hasLowerCase = /[a-z]+/.test(value);
        const hasNumeric = /[0-9]+/.test(value);
        const passwordValid = hasUpperCase && hasLowerCase && hasNumeric && hasSpecialCharacter;
        return !passwordValid ? {passwordStrength:true}: null;
    }
  }


}
