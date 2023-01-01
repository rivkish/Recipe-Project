import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Recipe } from 'src/models/Recipe';
import { User } from 'src/models/User';
import { RecipeSService } from '../recipe-s.service';

@Component({
  selector: 'app-small-recipe',
  templateUrl: './small-recipe.component.html',
  styleUrls: ['./small-recipe.component.scss']
})
export class SmallRecipeComponent implements OnInit {
  @Input()
recipe1:Recipe;
user=new User(1,"","","","");

  constructor(private router:Router,private rec:RecipeSService) { }
 print1(){
    if(this.user.Id!=0){
    console.log("print1")
    this.rec.r=this.recipe1;
    this.router.navigate(['fullr'])}
    else{
      alert("וודא שהינך מחובר לאתר")
    }
  }

  ngOnInit(): void {
    this.rec.r=this.recipe1;
    let jsonUser = localStorage.getItem("user");
   if(jsonUser){
     this.user = JSON.parse(jsonUser);

  }
 
}}

