import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Area from '../models/area';

@Injectable({
  providedIn: 'root'
})
export class ServAreaService {
  base_url = `https://localhost:44329/api/Area/`;
  constructor(private http: HttpClient) { }
  GetArea(): Observable<Area[]> {
    return this.http.get<Area[]>(`${this.base_url}GetAllArea`)
  }

}
