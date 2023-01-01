import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Recipe } from 'src/models/Recipe';

@Injectable({
  providedIn: 'root'
})
export class RecipeSService {
  upDateRecipe=new Subject();

  r:Recipe=new Recipe(0,"",0,0,0,new Date(),[],[],0,"",false)

getAllRecipe(){
  return this.myHttp.get<Recipe[]>("https://localhost:44336/api/recipe/GetAllRecipes");
}
AddRecipe(r:Recipe){
  return this.myHttp.post<Recipe[]>("https://localhost:44336/api/recipe/AddRecipe",r);
}
deleteRecipe(r:Recipe){
  return this.myHttp.post<Recipe[]>("https://localhost:44336/api/recipe/RemoveRecipe",r);
}
  constructor(public myHttp:HttpClient) { }
}
