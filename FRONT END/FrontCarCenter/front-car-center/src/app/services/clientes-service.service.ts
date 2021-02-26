import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from '../cliente';

const baseUrl = 'https://localhost:44326/api/clientes';
            
@Injectable({
  providedIn: 'root'
})
export class ClientesServiceService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<any> {
    return this.http.get(baseUrl);
  }

  get(id: String): Observable<any> {
    return this.http.get(`${baseUrl}/${id}`);
  }

  create(data: Cliente): Observable<any> {
    return this.http.post(baseUrl, data);
  }

  update(id: String, data: Cliente): Observable<any> {
    return this.http.put(`${baseUrl}/${id}`, data);
  }

  delete(id: String): Observable<any> {
    return this.http.delete(`${baseUrl}/${id}`);
  }

  // deleteAll(): Observable<any> {
 //   return this.http.delete(baseUrl);
 // }

   findByCedula(cedula: String): Observable<any> {
     return this.http.get(`${baseUrl}/${cedula}`);
   }
}