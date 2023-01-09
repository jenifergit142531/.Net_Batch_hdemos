import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent {

  salary:number=123456;
  today:number=Date.now();

  // public dropDownValue="";
  // SetDropDownValue(drpvalue:any){
  //   this.dropDownValue=drpvalue.target.value;

  // }

 /* isValid :boolean = true;
  changeData(valid:boolean)
  {
    this.isValid=valid;
  }*/


  students:any[] = [
  {
      Id:'101',FirstName:'Mira',LastName:'Reddy',Branch:'CSE',Gender:'Female'
    },
    {
      Id:'102',FirstName:'Amy',LastName:'Adams',Branch:'IT',Gender:'Female'
    },
    {
      Id:'103',FirstName:'James',LastName:'Stephen',Branch:'CSE',Gender:'Male'
    },
    {
      Id:'104',FirstName:'Aron',LastName:'Anderson',Branch:'IT',Gender:'Male'
    },
    {
      Id:'105',FirstName:'Steven',LastName:'Kelsey',Branch:'CSE',Gender:'Male'
    }
  ];

}
