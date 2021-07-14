import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Suppliers from '../models/suppliers';

@Injectable({
  providedIn: 'root'
})
export class ServSuppliersService {
  base_url = `https://localhost:44329/api/Suppliers/`;
  constructor(private http:HttpClient) { }
  GetSuppliers(): Observable<Suppliers[]> {
    return this.http.get<Suppliers[]>(`${this.base_url}GetAllSuppliers`)
  }
}
