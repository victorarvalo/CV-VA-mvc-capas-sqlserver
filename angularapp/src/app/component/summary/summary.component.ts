import { Component, OnInit } from '@angular/core';
import { SummaryDataServiceService } from "../../Services/SummaryData/summary-data.service.service"

@Component({
  selector: 'app-summary',
  templateUrl: './summary.component.html',
  styleUrls: ['./summary.component.css']
})
export class SummaryComponent implements OnInit{

  listSummaryData: any[] = [];

  constructor(private _summaryData: SummaryDataServiceService){

  }
  ngOnInit(): void {
    this._summaryData.getListPersonalData().subscribe((data: any[]) => {
      this.listSummaryData = data;
      console.log(data);
    },
    (error: any) => {
      console.log(error);
    })
  }
  backgroundColor(index: number){
    if((index % 2) == 0){
      return {'background-color': 'lightgrey'};
    }else{
      return {'background-color':'lightblue'};
    }
  }
}
