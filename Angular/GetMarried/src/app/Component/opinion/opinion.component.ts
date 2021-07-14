import { Component, OnInit } from '@angular/core';
import Opinion from 'src/app/models/opinion';
import { ServOpinionService } from 'src/app/Servies/serv-opinion.service';

@Component({
  selector: 'app-opinion',
  templateUrl: './opinion.component.html',
  styleUrls: ['./opinion.component.css']
})
export class OpinionComponent implements OnInit {
  opinionList:Opinion[]= []
  constructor(private serv:ServOpinionService) { }

  ngOnInit(): void {
    this.serv.GetOpinion().subscribe(res=>
      this.opinionList = res);
  }

}
