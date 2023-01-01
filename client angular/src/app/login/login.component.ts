import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/models/User';
import { UserService } from '../user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
user:User=new User(0,"","","","");
// userr:User;
ok=false;
ok2=false;
  constructor(private router:Router,public userSer:UserService ) { }
check(){
 this.ok=false;
  
  this.userSer.checkUser(this.user).subscribe(data=>{
    console.log("data "+data)

    if(data==true){
       this.ok=true;
       this.user.Password="";
    }


 else if(data==false){
this.router.navigate(['enter'])}
else{
  this.router.navigate(['allRecipe'])
  localStorage.setItem("user",JSON.stringify(data))
  this.userSer.upDateUser.next(data)
}
  })

}
disconct(){
  localStorage.setItem("user",JSON.stringify(new User(0,"אורח","","","")))
 this.userSer.upDateUser.next(new User(0,"אורח","","",""))
  // window.localStorage.clsear();
}

check2(){
  this.ok2=false;
   
   this.userSer.checkUser2(this.user).subscribe(data=>{
     console.log("data "+data)
 
     if(data==true){
        this.ok2=true;
        this.user.Password="";
     }
 
 
  else if(data==false){
 this.router.navigate(['enter'])}
 else{
   this.router.navigate(['allRecipe'])
   localStorage.setItem("user",JSON.stringify(data))
   this.userSer.upDateUser.next(data)
 }
   })
 
 }
  ngOnInit(): void {
  }
}
