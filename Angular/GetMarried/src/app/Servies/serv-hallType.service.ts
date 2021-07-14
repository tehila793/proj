import { Injectable } from '@angular/core';
import HallType from '../models/hallType';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServHallTypeService {
  base_url = `https://localhost:44329/api/HallType/`;
  constructor(private http:HttpClient) { }
  GetHallTYpe(): Observable<HallType[]> {
    return this.http.get<HallType[]>(`${this.base_url}GetAllHallType`)
  }
 
}
