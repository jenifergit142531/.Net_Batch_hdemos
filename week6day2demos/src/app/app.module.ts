import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ContactusComponent } from './contactus/contactus.component';
import { CoursedetailsComponent } from './coursedetails/coursedetails.component';
import { ErrorComponent } from './error/error.component';
import { ParentComponent } from './parent/parent.component';
import { ChildComponent } from './child/child.component';
import { FormsModule } from '@angular/forms';

import {MatTabsModule} from '@angular/material/tabs'; 


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ContactusComponent,
    CoursedetailsComponent,
    ErrorComponent,
    ParentComponent,
    ChildComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    MatTabsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
