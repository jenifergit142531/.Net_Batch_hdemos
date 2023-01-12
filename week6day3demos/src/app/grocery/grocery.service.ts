import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Grocery } from './grocery';


@Injectable({
  providedIn: 'root'
})
export class GroceryService {

  constructor(private http: HttpClient) { }

  // baseurl:'https://shoppingcart007.azurewebsites.net'

  get()
  {
    return this.http.get<Grocery[]>('http://localhost:3000/Grocery');


  }

  create(payload:Grocery)
  {
    return this.http.post<Grocery>('http://localhost:3000/Grocery',payload);
  }


  getById(id:number)
  {
    return this.http.get<Grocery>(`http://localhost:3000/Grocery/${id}`);
  }

  update(payload:Grocery)
  {
    return this.http.put(`http://localhost:3000/Grocery/${payload.id}`,payload);
  }

  delete(id:number)
  {
    return this.http.delete<Grocery>(`http://localhost:3000/Grocery/${id}`);
  }
}
