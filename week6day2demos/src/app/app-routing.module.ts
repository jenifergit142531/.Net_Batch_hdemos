import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CoursedetailsComponent } from './coursedetails/coursedetails.component';
import { ContactusComponent } from './contactus/contactus.component';
import { ErrorComponent } from './error/error.component';

const routes: Routes = [
  // {
  //  path:'',redirectTo:'contact',pathMatch:'full'
  // },
  {
    path:'home',component:HomeComponent
  },
  {
    path:'courses',component:CoursedetailsComponent
  },
  {
    path:'contact',component:ContactusComponent
  },
  {
    path:'**',component:ErrorComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
