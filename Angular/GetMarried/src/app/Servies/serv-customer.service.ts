import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import Customers from '../models/customers';

@Injectable({
  providedIn: 'root'
})
export class ServCustomerService {
  base_url = `https://localhost:44329/api/Customers/`;
  constructor(private http: HttpClient) {

  }
  GetCustomers(): Observable<Customers[]> {
    return this.http.get<Customers[]>(`${this.base_url}GetAllCustomers`)
  }
  // PostCustomers(cust:Customers) {
  //   return this.http.post(`${this.base_url}PostCustomer`,cust)
  // }
  
}
