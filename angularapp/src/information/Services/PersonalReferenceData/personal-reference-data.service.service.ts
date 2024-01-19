import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/enviroments/environment';

@Injectable({
  providedIn: 'root'
})
export class PersonalReferenceDataServiceService {

  private myAppUrl = environment.myAppUrl
  private myApiUrl = "api/PersonalReference"
  constructor(private http: HttpClient) { }

  getListPersonalReferenceData():Observable<any>{
    return this.http.get(this.myAppUrl + this.myApiUrl);
  }
}
