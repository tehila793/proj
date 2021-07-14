import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Halls from '../models/halls';

@Injectable({
  providedIn: 'root'
})
export class ServHallsService {
  base_url = `https://localhost:44329/api/Halls/`;
  constructor(private http:HttpClient) { }
  GetHalls(): Observable<Halls[]> {
    return this.http.get<Halls[]>(`${this.base_url}GetAllHalls`)
  }
}
