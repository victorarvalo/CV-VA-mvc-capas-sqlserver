import { Component, OnInit } from '@angular/core';
import { EducationDataServiceService } from './../../Services/EducationData/education-data.service.service'

@Component({
  selector: 'app-education-data-list',
  templateUrl: './education-data-list.component.html',
  styleUrls: ['./education-data-list.component.css']
})
export class EducationDataListComponent implements OnInit{

  listEducationData: any[] = [];
  
  constructor(private _educationData: EducationDataServiceService){

  }
  ngOnInit(): void {
    this._educationData.getListPersonalData().subscribe((data: any[]) => {
      /* data.forEach(element => {
        if(element.finishDate != null){
          var sfinishedDate: string[] = element.finishDate.split("/");
          var finishedDate: String = new Date(parseInt(sfinishedDate[2]),parseInt(sfinishedDate[1]),parseInt(sfinishedDate[0]))
          .toLocaleDateString('en-us',{year:'numeric'});
          element.finishDate = finishedDate.toString();
        }
      }); */
      this.listEducationData = data;
      console.log(data);
    },
    (error: any) => {
      console.log(error);
    })
  }
}
