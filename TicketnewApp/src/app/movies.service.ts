import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MoviesService {

  constructor() { }

  getCurrentMovies():any[]
  {
    return[
        {mid:'m101',mname:'avatar',location:'pvr',price:140},
        {mid:'m102',mname:'connect',location:'palazzo',price:200},
        {mid:'m103',mname:'driver',location:'spi',price:150},

    ]
  }

  getUpcomingMovies():any[]
  {
    return[
      {mid:'m104',mname:'Tunivu',location:'pvr',price:240},
      {mid:'m105',mname:'varisu',location:'palazzo',price:200},
      {mid:'m106',mname:'black adam',location:'spi',price:180},
    ]
  }



}
