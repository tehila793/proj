import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Service from '../models/servies';

@Injectable({
  providedIn: 'root'
})
export class ServServiceService {
  base_url = `https://localhost:44329/api/Service/`;
  constructor(private http: HttpClient) { }
  GetService(): Observable<Service[]> {
    return this.http.get<Service[]>(`${this.base_url}GetAllService`)
  }
}