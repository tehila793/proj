import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Address from '../models/address';
@Injectable({
  providedIn: 'root'
})
export class ServAddressService {
  base_url = `https://localhost:44329/api/Address/`;
  constructor(private http: HttpClient) { }
  GetAddress(): Observable<Address[]> {
    return this.http.get<Address[]>(`${this.base_url}GetAllAddress`)
  }
}
