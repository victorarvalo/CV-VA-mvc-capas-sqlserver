import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EducationDataServiceService {

  private myAppUrl = "https://localhost:7211/"
  private myApiUrl = "api/EducationData"
  constructor(private http: HttpClient) { }

  getListPersonalData():Observable<any>{
    return this.http.get(this.myAppUrl + this.myApiUrl);
  }
}
