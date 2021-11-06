import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { tap, delay } from 'rxjs/operators';
import { Pizza } from '../Models/Pizza';


@Injectable({
  providedIn: 'root'
})
export class ClienteService {

result : Observable<any>;

  constructor(private http : HttpClient) {}

  public listarPizza(id) : Observable<any>{
    return this.http.get(("https://localhost:44345/clientes/id=" + id), {withCredentials: true}); 
    }

}


