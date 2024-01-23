import { Component, OnInit } from '@angular/core';
import { ExperienceDataServiceService } from './../../Services/ExperienceData/experience-data.service.service'

@Component({
  selector: 'app-experien-data-list',
  templateUrl: './experien-data-list.component.html',
  styleUrls: ['./experien-data-list.component.css']
})
export class ExperienDataListComponent implements OnInit{
  
  listExperienceData: any[] = [];

  constructor(private _experienceData: ExperienceDataServiceService){

  }
  
  ngOnInit(): void {
    this._experienceData.getListExperienceData().subscribe(
      data => {
        this.listExperienceData = data;
        console.log(data);
      },
      error => {
        console.log(error);
      }
    )
  }

}
