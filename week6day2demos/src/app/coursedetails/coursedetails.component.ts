import { Component } from '@angular/core';

@Component({
  selector: 'app-coursedetails',
  templateUrl: './coursedetails.component.html',
  styleUrls: ['./coursedetails.component.css']
})
export class CoursedetailsComponent {


  courses:any[] = [
    {
      coursename:'BBA',Duration:'3',Topic:'Business administration',LastDOA:'25/1/2022' 
    },
    {
      coursename:'BCA',Duration:'3',Topic:'Computer Application',LastDOA:'28/1/2022' 
    },
    {
      coursename:'MBA',Duration:'2',Topic:'Master in Business administration',LastDOA:'30/1/2022'
    },
    {
      coursename:'MCA',Duration:'2',Topic:'Master in Computer Application',LastDOA:'30/1/2022'
    },
    {
      coursename:'BA',Duration:'3',Topic:'English Literature',LastDOA:'23/1/2022' 
    },
  ]

}
