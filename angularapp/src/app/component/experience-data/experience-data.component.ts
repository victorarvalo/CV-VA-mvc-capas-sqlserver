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
      data.forEach((element: {
        startDate: string; finishDate: string 
}) => {
        if(element.finishDate != null){
          var sfinishedDate: string[] = element.finishDate.split("/");
          var finishedDate: String = new Date(parseInt(sfinishedDate[2]),parseInt(sfinishedDate[1]),parseInt(sfinishedDate[0]))
          .toLocaleDateString('es-co',{year:'numeric',month:'long'});
          element.finishDate = finishedDate.toString().toUpperCase();
        }
        if(element.startDate != null){
          var sstartDate: string[] = element.startDate.split("/");
          var startedDate: String = new Date(parseInt(sstartDate[2]),parseInt(sstartDate[1]),parseInt(sstartDate[0]))
          .toLocaleDateString('es-co',{year:'numeric',month:'long'});
          element.startDate = startedDate.toString().toUpperCase();
        }
      })
      this.listExperienceData = data;
      console.log(data);
    },
    error => {
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
