import { Component , OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from '@angular/forms';
import {AbstractControl, ValidationErrors, ValidatorFn, FormControl} from '@angular/forms';
import { Department } from '../department';
import { Router } from '@angular/router';


@Component({
  selector: 'app-create-form',
  templateUrl: './create-form.component.html',
  styleUrls: ['./create-form.component.css']
})



export class CreateFormComponent {
  title = 'angularForm';
  itemSelected: string | undefined
  form!: FormGroup;
  fromDate =  new Date();
  endDate = '';  
  submited = false;
  departments: Department[] = [
    {
      id: "1",
      name: "phong 1",
      khoi: 1,
    },
    {
      id: "2",
      name: "phong 2",
      khoi: 2,
    },
  ];

  constructor(
    private fb: FormBuilder,
    private router: Router
    
  ) {}
  name:any
  ngOnInit(): void {
    // console.log(this.fromDate)
    // this.departments
    this.form = this.fb.group({
      name: ['',[Validators.required,this.nameValidator()]],
      rooms: ['',[Validators.required]],
      SD: ['',[Validators.required]],
      ED: ['',[Validators.required]],
      note:['',[Validators.required]]
    })
  }
  nameValidator(): ValidatorFn {
    return (control:AbstractControl) : ValidationErrors | null => {                                                                                                                                                                                                                                                 
        const value = control.value;
        if (!value) {
            return null;
        }
        const hasNumeric = /[0-9]+/.test(value);
        const hasSpecialCharacter = /[!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?]/.test(value);
        const nameInvalid =  hasNumeric || hasSpecialCharacter;
        return nameInvalid ? {passwordStrength:true}: null;
    }
  }
    // const state: FormState = {

    // }
    navtoReviewForm(){
      this.router.navigate(['/review'],{state:this.form.value})
    }
    onChangeDepartment(param: any){
      console.log(param?.target?.value)
    }
    onSubmit() {
    console.log(this.form.get('SD')?.value) 
    console.log(this.form.value);

    this.submited = true;
    this.form.markAllAsTouched()
  
  }
  
}






