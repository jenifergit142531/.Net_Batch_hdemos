import { Component, OnInit } from '@angular/core';
import { GroceryService } from '../grocery.service';
import { Router } from '@angular/router';
import { Grocery } from '../grocery';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  groceryForm : Grocery={
     id:0,
     name:'',
     quantity:0,
     price:0

  };

  constructor(private groceryService:GroceryService,private router:Router){}
  
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  create()
  {
    this.groceryService.create(this.groceryForm)
    .subscribe({
      next:(data)=>{
        this.router.navigate(["/grocery/home"])
      },
      error:(err)=>
      console.log(err)
    })
  }
}








