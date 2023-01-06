import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  //template:'<button (click)="greet()">Greetings</button>',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TicketnewApp';

  greet():void{
    alert("Hello everyone");
  }
}
