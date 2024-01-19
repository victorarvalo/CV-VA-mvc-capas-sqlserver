import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from './../../../enviroments/environment';

@Injectable({
  providedIn: 'root'
})
@Injectable({
  providedIn: 'root'
})
export class ExperienceDataServiceService {

  private myAppUrl = environment.myAppUrl
  private myApiUrl = "api/ExperienceData"
  constructor(private http: HttpClient) { }

  getListExperienceData():Observable<any>{
    return this.http.get(this.myAppUrl + this.myApiUrl);
  }
}
