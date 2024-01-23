import { Component, OnInit } from '@angular/core';
import { SvgIconRegistryService } from 'angular-svg-icon';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit{

  constructor(private _registry: SvgIconRegistryService){

  }
  ngOnInit(): void {
    this._registry.loadSvg("/assets/imgVictorSVGsvg.svg","vic");
  }
}
