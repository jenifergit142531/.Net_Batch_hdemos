import { Pipe, PipeTransform } from '@angular/core';
import { ignoreElements } from 'rxjs';

@Pipe({
  name: 'myTitle'
})
export class MyTitlePipe implements PipeTransform {

  transform(firstName:string,gender:string): string {
   if(gender.toLowerCase()=="male")
   return "Mr."+ firstName;
   else
   return "Miss ."+firstName;
  }

}
