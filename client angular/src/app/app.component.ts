import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { User } from 'src/models/User';
import { UserService } from './user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  constructor(public us:UserService){}
  sub:Subscription;
user:any;
  ngOnInit(){

    this.user=new User(0,"","","","");
   let jsonUser = localStorage.getItem("user");

   if(jsonUser){
     this.user = JSON.parse(jsonUser);
   }

 this.sub= this.us.upDateUser.subscribe(data=>{this.user=data;console.log("app- "+data)})

  }
 

  title = 'project';
  activeLink=1;
}
