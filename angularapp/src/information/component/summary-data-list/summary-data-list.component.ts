import { Component, OnInit } from '@angular/core';
import { SummaryDataServiceService } from "./../../Services/SummaryData/summary-data.service.service"

@Component({
  selector: 'app-summary-data-list',
  templateUrl: './summary-data-list.component.html',
  styleUrls: ['./summary-data-list.component.css']
})

export class SummaryDataListComponent implements OnInit{
  
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

}
