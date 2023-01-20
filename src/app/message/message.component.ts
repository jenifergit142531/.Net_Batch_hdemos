import { Component } from '@angular/core';

@Component({
  selector: 'app-message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.css']
})
export class MessageComponent {

  message: string = '';

  constructor() {}

  setMessage(newMessage: string) {
      this.message = newMessage;
  }

  clearMessage() {
    this.message = 'gjhhj';
  }

}
