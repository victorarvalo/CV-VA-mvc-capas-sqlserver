import { Component, OnInit } from '@angular/core';
import { PersonalReferenceDataServiceService } from './../../Services/PersonalReferenceData/personal-reference-data.service.service';

@Component({
  selector: 'app-personal-reference-data-list',
  templateUrl: './personal-reference-data-list.component.html',
  styleUrls: ['./personal-reference-data-list.component.css']
})
export class PersonalReferenceDataListComponent implements OnInit{

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
}
