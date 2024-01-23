import { Component, Input, OnInit } from '@angular/core';


@Component({
  selector: 'app-personal-reference-data',
  templateUrl: './personal-reference-data.component.html',
  styleUrls: ['./personal-reference-data.component.css']
})
export class PersonalReferenceDataComponent implements OnInit {
  
  @Input() 
  personalReference: any;

  constructor(){

  }
  
  ngOnInit(): void {
    
  }

  backgroundColor(index: number){
    if((index % 2) == 0){
      return {'background-color': 'lightgrey'};
    }else{
      return {'background-color':'lightblue'};
    }
  }
}
