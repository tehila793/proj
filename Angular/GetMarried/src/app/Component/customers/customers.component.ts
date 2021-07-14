import { Component, OnInit } from '@angular/core';
import Customers from 'src/app/models/customers';
import { ServCustomerService } from 'src/app/Servies/serv-customer.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  customerList:Customers[]=[]
  constructor(private serv:ServCustomerService) { }

  ngOnInit(): void {
    this.serv.GetCustomers().subscribe(res=>
      this.customerList = res);
  }
  
  // add(cust:Customers)
  // {

  // }
}
