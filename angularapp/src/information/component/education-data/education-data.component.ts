import { Component, Input, OnInit } from '@angular/core';




@Component({
  selector: 'app-education-data',
  templateUrl: './education-data.component.html',
  styleUrls: ['./education-data.component.css']
})
export class EducationDataComponent implements OnInit{

  
 @Input() educationData: any;

  constructor(){

  }
  
  ngOnInit(): void {
    
  }

  styles(): { [klass: string]: any; }|null|undefined {
    var institutionString: string = this.educationData.institution;
    if(institutionString.includes("Salle")){
      return {
        'background-image': 'url("./../../../assets/salle.png")',
        'background-size': 'cover'
      }
    }
    if(institutionString.includes("Interamericano")){
      return {
        'background-image': 'url("./../../../assets/colegioInteramericano.png")',
        'background-size': 'cover'
      }
    }
    if(institutionString.includes("Angular")){
      return {
        'background-image': 'url("./../../../assets/angular.png")',
        'background-size': 'cover'
      }
    }
    if(institutionString.includes("Sena")){
      return {
        'background-image': 'url("./../../../assets/sena.png")',
        'background-size': 'cover'
      }
    }
    if(institutionString.includes("Udemy")){
      return {
        'background-image': 'url("./../../../assets/udemy.png")',
        'background-size': 'cover'
      }
    }
    if(institutionString.includes("KOE")){
      return {
        'background-image': 'url("./../../../assets/koe.png")',
        'background-size': 'cover'
      }
    }
    return undefined;
    }

}
