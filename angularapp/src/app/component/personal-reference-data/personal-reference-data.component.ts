import { Component, OnInit } from '@angular/core';
import { PersonalReferenceDataServiceService } from 'src/app/Services/PersonalReferenceData/personal-reference-data.service.service';

@Component({
  selector: 'app-personal-reference-data',
  templateUrl: './personal-reference-data.component.html',
  styleUrls: ['./personal-reference-data.component.css']
})
export class PersonalReferenceDataComponent implements OnInit {
  
  listPersonalReference: any[] = [];

  constructor(private _personalReference: PersonalReferenceDataServiceService){

  }
  
  ngOnInit(): void {
    this._personalReference.getListPersonalReferenceData().subscribe(data=>{
      this.listPersonalReference = data;
      console.log(data);
    },
    error=>{
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
