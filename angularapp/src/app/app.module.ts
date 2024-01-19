import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { AngularSvgIconModule } from 'angular-svg-icon';
import { NavComponent } from './nav/nav.component'
import { InformationModule } from 'src/information/information.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';







@NgModule({
  declarations: [
    AppComponent,
    NavComponent
    
  ],
  imports: [
    BrowserModule, 
    HttpClientModule, 
    AppRoutingModule, 
    AngularSvgIconModule.forRoot(),
    InformationModule, 
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
