
import { Component, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent  {

  // @Input() childMessage:string='';
  // constructor(){
    
  // };
   message : string ="Intercomponent interaction demo";

   @Output() messageEvent = new EventEmitter<string>();

  sendMessage()
  {
    this.messageEvent.emit(this.message);
  }
   


}
