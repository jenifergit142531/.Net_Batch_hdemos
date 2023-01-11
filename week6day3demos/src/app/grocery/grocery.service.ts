import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Grocery } from './grocery';


@Injectable({
  providedIn: 'root'
})
export class GroceryService {

  constructor(private http: HttpClient) { }


  get()
  {
    return this.http.get<Grocery[]>('http://localhost:3000/Grocery');
  }

}
