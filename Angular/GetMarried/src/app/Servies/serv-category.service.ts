import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import Category from '../models/category';
@Injectable({
  providedIn: 'root'
})
export class ServCategoryService {
  base_url = `https://localhost:44329/api/Categories/`;
  constructor(private http: HttpClient) {

  }
  GetCategories(): Observable<Category[]> {
    return this.http.get<Category[]>(`${this.base_url}GetAllCategories`)
  }

}
