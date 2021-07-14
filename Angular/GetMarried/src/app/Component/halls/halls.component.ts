import { Component, OnInit } from '@angular/core';
import { ServHallsService } from 'src/app/Servies/serv-halls.service';
import Halls from '../../models/halls';

@Component({
  selector: 'app-halls',
  templateUrl: './halls.component.html',
  styleUrls: ['./halls.component.css']
})
export class HallsComponent implements OnInit {
  hallsList:Halls[]= []
  constructor(private serv:ServHallsService) { }

  ngOnInit(): void {
     this.serv.GetHalls().subscribe(res=>
     this.hallsList = res);
  }

}
