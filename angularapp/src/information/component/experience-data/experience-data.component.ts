import { Component, OnInit, Input } from '@angular/core';


@Component({
  selector: 'app-experience-data',
  templateUrl: './experience-data.component.html',
  styleUrls: ['./experience-data.component.css']
})

export class ExperienceDataComponent implements OnInit{
  
  @Input()
  experienceData: any;

  visible = true;

  //datasources tables
  detailSummaryDataSource: any[] = [];
  skillsDataSource: any[] = [];
  //displayColumns
  detailSummaryDisplayColumns = ['detail'];
  skillsDisplayColumns = ['skill1'];

  constructor(){

  }
  
  ngOnInit(): void {
    /* let startDate: string; 
    let finishDate: string;
    if(this.experienceData.finishDate != null){
      var sfinishedDate: string[] = this.experienceData.finishDate.split("/");
          var finishedDate: String = new Date(parseInt(sfinishedDate[2]),parseInt(sfinishedDate[1]),parseInt(sfinishedDate[0]))
          .toLocaleDateString('es-co',{year:'numeric',month:'long'});
          this.experienceData.finishDate = finishedDate.toString().toUpperCase();
    }
    if(this.experienceData.startDate != null){
      var sstartDate: string[] = this.experienceData.startDate.split("/");
      var startedDate: String = new Date(parseInt(sstartDate[2]),parseInt(sstartDate[1]),parseInt(sstartDate[0]))
      .toLocaleDateString('es-co',{year:'numeric',month:'long'});
      this.experienceData.startDate = startedDate.toString().toUpperCase();
    }   */   

    this.detailSummaryDataSource = this.experienceData.detailSummaries;
    this.skillsDataSource = this.experienceData.skills;
  }

  toggle(){
    this.visible = !this.visible;
  }
}
