import { Component, OnInit } from '@angular/core';
import { GroceryService } from '../grocery.service';
import { Grocery } from '../grocery';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  allGrocery: Grocery[] = [];

  constructor(private groceryService:GroceryService){}
   
  ngOnInit(): void {
    this.get();
  }

  get(){
    this.groceryService.get().subscribe((data)=>{
      this.allGrocery=data;
    });
  }



}
