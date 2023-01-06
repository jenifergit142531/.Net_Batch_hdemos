import { Component } from '@angular/core';
import { MoviesService } from '../movies.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
 
  styleUrls: ['./home.component.css']
})
export class HomeComponent {

  currentMovie:any[];
  upcomingMovies:any[];

  constructor(public service:MoviesService)
  {
    this.currentMovie=this.service.getCurrentMovies();
    this.upcomingMovies=this.service.getUpcomingMovies();
  }
   


  
  


  message:string="This is string interpolation";

  imagePath:string="assets/chart.png";

  tableHeader:string="Student Details";
  firstName:string="Mira";
  lastName:string="SJ";
  Grade:string="A";
  Gender:string="Female";
  column:number=2;

  color:string="Red"

 greeting():void{
  alert("Event binding")
 }

 Name:string="Jeni";



  showMessage():string
  {
     return this.message;
  }

}
