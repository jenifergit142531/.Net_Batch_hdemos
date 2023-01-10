import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'week6day2demos';
  constructor(private router:Router)
  {
    
  }
  //Server side routing
  
  GetHome()
  {
     this.router.navigate(['/home']);
  }
  GetCourse()
  {
     this.router.navigate(['/courses']);
  }
  GetContact()
  {
     this.router.navigate(['/contact']);
  }
}
