import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from './../../../enviroments/environment';

@Injectable({
  providedIn: 'root'
})
export class EducationDataServiceService {

  private myAppUrl = environment.myAppUrl
  private myApiUrl = "api/EducationData"
  constructor(private http: HttpClient) { }

  getListPersonalData():Observable<any>{
    return this.http.get(this.myAppUrl + this.myApiUrl);
  }
}
