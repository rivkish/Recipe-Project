import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { User } from 'src/models/User';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  upDateUser=new Subject();
  constructor(public myHttp:HttpClient) { }

 data:any;

  checkUser(us:User){
    
   return this.myHttp.post("https://localhost:44336/api/user/Login",us);
     
 }
 checkUser2(us:User){
    
  return this.myHttp.post("https://localhost:44336/api/user/Login2",us);
    
}
 addUser(us:User){
  
   let x = this.myHttp.post("https://localhost:44336/api/user/Register",us);
   return x;
 }

}
