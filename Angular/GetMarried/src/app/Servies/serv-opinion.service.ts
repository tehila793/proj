import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import Opinion from '../models/opinion';

@Injectable({
  providedIn: 'root'
})
export class ServOpinionService {
  base_url = `https://localhost:44329/api/Opinion/`;
  constructor(private http:HttpClient) { }
  GetOpinion(): Observable<Opinion[]> {
    return this.http.get<Opinion[]>(`${this.base_url}GetAllOpinion`)
  }
 
}
