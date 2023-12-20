import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { AngularSvgIconModule } from 'angular-svg-icon';
import { PersonalDataComponent } from './component/personal-data/personal-data.component';
import { SummaryComponent } from './component/summary/summary.component';
import { EducationDataComponent } from './component/education-data/education-data.component';
import { ExperienceDataComponent } from './component/experience-data/experience-data.component';
import { PersonalReferenceDataComponent } from './component/personal-reference-data/personal-reference-data.component';
import { NavComponent } from './component/nav/nav.component';
import { FullinformationComponent } from './component/fullinformation/fullinformation.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonalDataComponent,
    SummaryComponent,
    EducationDataComponent,
    ExperienceDataComponent,
    PersonalReferenceDataComponent,
    NavComponent,
    FullinformationComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, AppRoutingModule, AngularSvgIconModule.forRoot() 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
