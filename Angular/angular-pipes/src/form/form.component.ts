import { CommonModule } from '@angular/common';
import { Component, NgModule } from '@angular/core';
import { FormGroup, ReactiveFormsModule } from '@angular/forms';
import { FormControl } from '@angular/forms';
import { Validators } from '@angular/forms';
import { UpperCasePipe } from '@angular/common';  
import { ActiveProjectsPipePipe } from '../active-projects-pipe.pipe';

interface Iemployee{
  projectList :  FormControl<object| null>
  firstName : FormControl<string | null>;
  lastName : FormControl<string | null>;
  email:  FormControl<string | null>;
  phoneNo : FormControl<number | null>;
  address : FormGroup<Iaddress>;
}

interface Iaddress{
  addressLine1 : FormControl<string | null>;
  addressLine2 : FormControl<string | null>;
  city :  FormControl<string | null>;
}


@Component({
  selector: 'app-form',
  standalone: true,
  imports: [ReactiveFormsModule,CommonModule,UpperCasePipe,ActiveProjectsPipePipe],
  templateUrl: './form.component.html',
  styleUrl: './form.component.scss'
})
export class FormComponent {

  projectList = [
    { "name": "Hilite", "isActive": true },
    { "name": "Lulu", "isActive": true },
    { "name": "Cordova School", "isActive": true },
    { "name": "Azure Heights Apartments", "isActive": true },
    { "name": "Greenfield Mall", "isActive": true },
    { "name": "Pinnacle Corporate Towers", "isActive": true },
    { "name": "Sunshine Valley Resort", "isActive": true },
    { "name": "Everest Office Park", "isActive": false },
    { "name": "Maplewood Villas", "isActive": false },
    { "name": "Sterling Shopping Complex", "isActive": false }
  ]
  

  submitted = false;

  employee = new FormGroup<Iemployee>({
    projectList : new FormControl(null),
    firstName : new FormControl('',Validators.required),
    lastName : new FormControl('',Validators.required),
    email : new FormControl('',[Validators.required,Validators.pattern(/^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$/)]),
    phoneNo : new FormControl(null,Validators.pattern('^[0-9]{10}$')),
    address : new FormGroup({
      addressLine1 : new FormControl(''),
      addressLine2 : new FormControl(''),
      city :  new FormControl('')
    })
  })

  
  onSubmit(){
    console.log("onSubmit called")
    if(this.employee.valid){
      this.submitted = true
    }    
  }
  
}



