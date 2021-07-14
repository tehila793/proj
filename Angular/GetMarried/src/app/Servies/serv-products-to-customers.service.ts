import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import ProductsToCustomers from '../models/productsToCustomers';

@Injectable({
  providedIn: 'root'
})
export class ServProductsToCustomersService {
  base_url = `https://localhost:44329/api/ProductsToCustomers/`;
  constructor(private http:HttpClient) { }
  GetProductsToCustomers(): Observable<ProductsToCustomers[]> {
    return this.http.get<ProductsToCustomers[]>(`${this.base_url}GetAllProductsToCustomers`)
  }
}
