import { Component, OnInit } from '@angular/core';
import { GroceryService } from '../grocery.service';
import { Grocery } from '../grocery';

declare var window:any;
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  allGrocery: Grocery[] = [];


    deleteModal:any;
    idToDelete:number=0;


  constructor(private groceryService:GroceryService){}
   
  ngOnInit(): void {
    
    
    this.deleteModal=new window.bootstrap.Modal(
      document.getElementById('deleteModal')
    );

    this.get();

    
    }

  get(){
    this.groceryService.get().subscribe((data)=>{
      this.allGrocery=data;
    });
  }

  

  openDeleteModal(id: number) {
    this.idToDelete=id;
    this.deleteModal.show();
}

  

  delete(){
    this.groceryService.delete(this.idToDelete).subscribe({
      next:(data)=>
      {
        this.allGrocery=this.allGrocery.filter(_=>_.id !=this.idToDelete);
        this.deleteModal.hide();
      }
    });
  }


}


