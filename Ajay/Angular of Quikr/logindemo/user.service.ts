import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class UserService {
  
  private baseUrl = 'http://localhost:6663/api';
  
  constructor(private http: HttpClient) { }

  createUser(userAccount: Object): Observable<Object> {
    console.log(userAccount)
    return this.http.post(`${this.baseUrl}` + `/save`, userAccount);
  }

   validateUser(loginAccount: Object): Observable<Object> {
    console.log(loginAccount)
    return this.http.post(`${this.baseUrl}` + `/validate`,loginAccount);
  } 

}