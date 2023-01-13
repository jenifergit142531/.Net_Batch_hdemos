import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-templatevalidator',
  templateUrl: './templatevalidator.component.html',
  styleUrls: ['./templatevalidator.component.css']
})
export class TemplatevalidatorComponent {

  form={
   
    username: '',
    email: '',
    password: ''
  };


 onSubmit():void{
  console.log(JSON.stringify(this.form,null,2));
 }


 onReset(form:NgForm):void{
  form.reset();
 }




}
