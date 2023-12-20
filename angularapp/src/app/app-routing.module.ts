import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { PersonalDataComponent } from './component/personal-data/personal-data.component';
import { SummaryComponent } from './component/summary/summary.component';
import { EducationDataComponent } from './component/education-data/education-data.component';
import { ExperienceDataComponent } from './component/experience-data/experience-data.component';
import { PersonalReferenceDataComponent } from './component/personal-reference-data/personal-reference-data.component';
import { FullinformationComponent } from './component/fullinformation/fullinformation.component';

const routes: Routes = [
  {path:'PersonalData',component:PersonalDataComponent},
  {path:'Summary',component:SummaryComponent},
  {path:'EducationData',component:EducationDataComponent},
  {path:'ExperienceData',component:ExperienceDataComponent},
  {path:'PersonalReference',component:PersonalReferenceDataComponent},
  {path:'FullInformation',component:FullinformationComponent}  
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
