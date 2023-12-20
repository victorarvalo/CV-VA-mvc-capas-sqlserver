import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SummaryDataServiceService {

  private myAppUrl = "https://localhost:7175/"
  private myApiUrl = "api/SummaryData"
  constructor(private http: HttpClient) { }

  getListPersonalData():Observable<any>{
    return this.http.get(this.myAppUrl + this.myApiUrl);
  }
}
