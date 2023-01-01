import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Recipe } from 'src/models/Recipe';
import { User } from 'src/models/User';
import { RecipeSService } from '../recipe-s.service';

@Component({
  selector: 'app-fullr',
  templateUrl: './fullr.component.html',
  styleUrls: ['./fullr.component.scss']
})
export class FullrComponent implements OnInit {
  recipe2:Recipe=new Recipe(0,"",0,0,0,new Date(),[],[],0,"",false)
user:User=new User(1,"","","","");
  constructor(private rec:RecipeSService,public router:Router) { }
delete(){
  
  if(this.recipe2.UserId==this.user.Id){
    alert("נמחק בהצלחה")
this.router.navigate(['allRecipe'])
    return this.rec.deleteRecipe(this.recipe2).subscribe(data => {console.log(data);});}
  else
  alert("אינך רשאי לבצע פעולה זו")
  return 0;
}
  ngOnInit(): void {
this.recipe2=this.rec.r;
let jsonUser = localStorage.getItem("user");

if(jsonUser){
  this.user = JSON.parse(jsonUser);
  }

}}
