import { Component, OnInit } from '@angular/core';
import { ServCategoryService } from 'src/app/Servies/serv-category.service';
import Category from '../../models/category';


@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
  
export class CategoryComponent implements OnInit {
  categoryList:Category[]= []
  constructor(private serv:ServCategoryService ) { }
  ngOnInit(): void {
    this.serv.GetCategories().subscribe(res=>
      this.categoryList = res);
  }

}
