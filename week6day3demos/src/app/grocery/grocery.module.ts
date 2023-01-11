import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GroceryRoutingModule } from './grocery-routing.module';
import { HomeComponent } from './home/home.component';
import { CreateComponent } from './create/create.component';
import { FormsModule } from '@angular/forms'


@NgModule({
  declarations: [
    HomeComponent,
    CreateComponent
  ],
  imports: [
    CommonModule,
    GroceryRoutingModule,
    FormsModule
  ]
})
export class GroceryModule { }
