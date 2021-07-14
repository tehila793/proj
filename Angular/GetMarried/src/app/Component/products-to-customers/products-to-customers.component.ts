import { Component, OnInit } from '@angular/core';
import ProductsToCustomers from 'src/app/models/productsToCustomers';
import { ServProductsToCustomersService } from 'src/app/Servies/serv-products-to-customers.service';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-products-to-customers',
  templateUrl: './products-to-customers.component.html',
  styleUrls: ['./products-to-customers.component.css']
})
export class ProductsToCustomersComponent implements OnInit {
 private productsToCustomerList:ProductsToCustomers[]=[]
  constructor(private serv:ServProductsToCustomersService) { }

  ngOnInit(): void {
   this.serv.GetProductsToCustomers().subscribe(res=>
      this.productsToCustomerList = res);
  }

}
