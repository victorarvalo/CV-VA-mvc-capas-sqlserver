import { Component, Input, OnInit } from '@angular/core';
import { SummaryDataServiceService } from "./../../Services/SummaryData/summary-data.service.service"

@Component({
  selector: 'app-summary',
  templateUrl: './summary.component.html',
  styleUrls: ['./summary.component.css']
})
export class SummaryComponent implements OnInit{

  @Input() summaryData: any; 

  constructor(private _summaryData: SummaryDataServiceService){

  }
  
  ngOnInit(): void {
    
  }
}
