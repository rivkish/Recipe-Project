import { Component, OnInit } from '@angular/core';
import { Category } from 'src/models/Category';
import { Layer } from 'src/models/Layer';
import { Recipe } from 'src/models/Recipe';
import { CategoryService } from '../category.service';
import {FormControl} from '@angular/forms';
import { User } from 'src/models/User';
import { RecipeSService } from '../recipe-s.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.scss']
})

export class AddComponent implements OnInit {
disableSelect = new FormControl(false);
user=new User(1,"","","","");
recipe:any;
//  recipe:Recipe=new Recipe(0,"",0,0,0,new Date(),[new Layer("",[""])],[""],this.user.Id,"",false)
l:Layer;
ok1=false;
ok2=false;
  constructor(public catser:CategoryService,public recser:RecipeSService,public router:Router) { }
num:number=0;
categorys:Category[];
vv=false;
  numl()
  {
 this.recipe.Layers.push(new Layer("",[""]))

  }
  trackByIdx(index:number,obj:any):any{
return index
    
  }addP(){
    this.recipe.Preparation.push("");

  }
  addR(){
   if(this.user.Id==0){
     console.log("addr")
     this.ok2=true
     return 0;
   }
   else
   {
  return this.recser.AddRecipe(this.recipe).subscribe(data => {console.log(data);
    this.ok1=true;
    });
    this.recipe=new Recipe(0,"",0,0,0,new Date(),[new Layer("",[""])],[""],this.user.Id,"../../assets/images/הורדה.png",false)
  }
 }
 v(){
   this.vv=true;
 }
 addC(e:any){
this.recipe.Layers[e.id].Components.push("")
 }
 login(){
  this.router.navigate(['login'])

 }
  ngOnInit(): void {
    this.catser.getAllCategory().subscribe(s=> {
      this.categorys=s;} ,erorr=>{console.log("error")})

   let jsonUser = localStorage.getItem("user");

   if(jsonUser){
     this.user = JSON.parse(jsonUser);
     console.log(this.user)
 this.recipe=new Recipe(0,"",0,0,0,new Date(),[new Layer("",[""])],[""],this.user.Id,"../../assets/images/הורדה.png",false)

  }

  }}
