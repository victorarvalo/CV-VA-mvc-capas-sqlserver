import { Component, OnInit } from '@angular/core';
import { ExperienceDataServiceService } from 'src/app/Services/ExperienceData/experience-data.service.service';

@Component({
  selector: 'app-experience-data',
  templateUrl: './experience-data.component.html',
  styleUrls: ['./experience-data.component.css']
})
export class ExperienceDataComponent implements OnInit{
  
  listExperienceData: any[] = [];

  constructor(private _experienceData: ExperienceDataServiceService){

  }
  
  ngOnInit(): void {
    this._experienceData.getListExperienceData().subscribe(data => {
//       
      this.listExperienceData = data;
      console.log(data);
    },
    error => {
      console.log(error);
    })
  }

  backgroundColor(index: number){
    if((index % 2) == 0){
      return {'background-color': 'lightgrey','padding-top': '1px'};
    }else{
      return {'background-color':'lightblue','padding-top': '1px'};
    }
  }
}
