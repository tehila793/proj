import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import Address from 'src/app/models/address';
import { ServAddressService } from 'src/app/Servies/serv-address.service';

@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit {
  addressList:Address[]= []
  constructor(private serv:ServAddressService) { }

  ngOnInit(): void {
    this.serv.GetAddress().subscribe(res =>
      this.addressList = res);
  }

}
