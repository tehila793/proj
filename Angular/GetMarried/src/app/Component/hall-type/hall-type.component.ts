import { Component, OnInit } from '@angular/core';
import HallType from 'src/app/models/hallType';
import { ServHallTypeService } from 'src/app/Servies/serv-hallType.service';

@Component({
  selector: 'app-hall-type',
  templateUrl: './hall-type.component.html',
  styleUrls: ['./hall-type.component.css']
})
export class HallTypeComponent implements OnInit {

  hallTypeList:HallType[]=[]
  constructor(private serv:ServHallTypeService) { }

  ngOnInit(): void {
    this.serv.GetHallTYpe().subscribe(res=>
      this.hallTypeList = res);
  }

}
