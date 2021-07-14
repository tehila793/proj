import { Component, OnInit } from '@angular/core';
import Area from 'src/app/models/area';
import { ServAreaService } from 'src/app/Servies/serv-area.service';

@Component({
  selector: 'app-area',
  templateUrl: './area.component.html',
  styleUrls: ['./area.component.css']
})
export class AreaComponent implements OnInit {
  areaList: Area[] = []
  constructor(private serv: ServAreaService) { }
  
  ngOnInit(): void {
    this.serv.GetArea().subscribe(res =>
      this.areaList = res);
  }

}
