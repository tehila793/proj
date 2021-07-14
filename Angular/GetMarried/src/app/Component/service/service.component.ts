import { Component, OnInit } from '@angular/core';
import Service from 'src/app/models/servies';
import { ServServiceService } from 'src/app/Servies/serv-service.service';

@Component({
  selector: 'app-service',
  templateUrl: './service.component.html',
  styleUrls: ['./service.component.css']
})
export class ServiceComponent implements OnInit {
  serviceList:Service[]= []
  constructor(private serv:ServServiceService) { }

  ngOnInit(): void {
    this.serv.GetService().subscribe(res=>
      this.serviceList = res);
  }
}
