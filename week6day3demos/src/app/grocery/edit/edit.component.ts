import { Component, OnInit } from '@angular/core';
import { Grocery } from '../grocery';
import { GroceryService } from '../grocery.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {

  groceryForm:Grocery={
     id:0,
     name:'',
     quantity:0,
     price:0,

  };

  constructor(private route:ActivatedRoute,
    private groceryService:GroceryService
    ,private router:Router){}

  ngOnInit(): void {
    
    this.route.paramMap.subscribe((param)=>
    {
      var id = Number(param.get('id'));
      this.getById(id);
    });
  }

  getById(id:number)
  {
    this.groceryService.getById(id).subscribe((data)=>
    {
     this.groceryForm=data;
     //console.log(data);
    });
  }

  update()
  {
    this.groceryService.update(this.groceryForm)
    .subscribe({
      next:(data)=>{
        this.router.navigate(["/grocery/home"]);
      },
      error:(err)=>
      {
        console.log(err);
      }
    });
  }

}
