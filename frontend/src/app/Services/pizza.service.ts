import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Pizza } from '../Models/Pizza';

@Injectable({
  providedIn: 'root'
})
export class PizzaService {

  constructor(private http: HttpClient) { }
  
  public listarPizzas() : Observable<any>{
    return this.http.get("https://localhost:44345/pizzas/");
  }
}
