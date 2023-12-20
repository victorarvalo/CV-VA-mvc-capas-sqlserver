import { Component, OnInit, numberAttribute } from '@angular/core';
import { PersonalDataServiceService } from '../../Services/PersonalData/personal-data.service.service'

@Component({
  selector: 'app-personal-data',
  templateUrl: './personal-data.component.html',
  styleUrls: ['./personal-data.component.css']
})
export class PersonalDataComponent implements OnInit{

  listPersonalData: any[] = [];

  constructor(private _personalData: PersonalDataServiceService){

  }

  ngOnInit(): void {
    this._personalData.getListPersonalData().subscribe((data: any[]) => {
      this.listPersonalData = data;
      console.log(data);
    },
      (error: any) => {
      console.log(error);
    }
    );
  }

  backGroundClass(odd: boolean){
    if(odd){
      return {'background-color': 'lightgrey'};
    }else{
      return {'background-color':'lightblue'};
    }
  }

}
