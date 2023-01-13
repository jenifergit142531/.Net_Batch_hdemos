import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl,FormBuilder,FormArray,Validators} from '@angular/forms'
@Component({
  selector: 'app-jobportal',
  templateUrl: './jobportal.component.html',
  styleUrls: ['./jobportal.component.css']
})
export class JobportalComponent  implements OnInit{
  constructor(private fb:FormBuilder){}

  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  // jobForm=new FormGroup({
  //   firstname:new FormControl(''),
  //   lastname: new FormControl('')
    
  // });

  jobForm = this.fb.group({

    firstname:['',[Validators.required]],
    lastname:['',[Validators.minLength(6)]]

  });
  preview:string='';

  save()
  {
    this.preview=JSON.stringify(this.jobForm.value);
  }

  get firstname()
  {
    return this.jobForm.get('firstname');
  }

}
