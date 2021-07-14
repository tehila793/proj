import { Component, OnInit } from '@angular/core';
import Suppliers from 'src/app/models/suppliers';
import { ServSuppliersService } from 'src/app/Servies/serv-suppliers.service';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.css']
})
export class SuppliersComponent implements OnInit {
  suppliersList:Suppliers[]=[]
  constructor(private serv:ServSuppliersService) { }

  ngOnInit(): void {
    this.serv.GetSuppliers().subscribe(res=>
      this.suppliersList = res);
  }

}
