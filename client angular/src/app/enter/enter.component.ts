import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/models/User';
import { UserService } from '../user.service';

@Component({
  selector: 'app-enter',
  templateUrl: './enter.component.html',
  styleUrls: ['./enter.component.scss']
})
export class EnterComponent implements OnInit {

user:User=new User(0,"","","","");
ok1=false;
vv=false;
  constructor(public us:UserService,private router:Router) { }
  v(){
    this.vv=true;
  }
add(){

  console.log(this.user)
return this.us.addUser(this.user).subscribe(data => {console.log(data);
this.ok1=true;this.us.upDateUser.next(data)
localStorage.setItem("user",JSON.stringify(data))
});
this.user=new User(0,"","","","");


}

ok(){
  this.router.navigate(['allRecipe'])

}
  ngOnInit(): void {
  }

}
