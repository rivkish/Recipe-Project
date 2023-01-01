import { Component, OnInit, Output } from '@angular/core';
import { Category } from 'src/models/Category';
import { Recipe } from 'src/models/Recipe';
import { CategoryService } from '../category.service';
import { RecipeSService } from '../recipe-s.service';

@Component({
  selector: 'app-all-recipe',
  templateUrl: './all-recipe.component.html',
  styleUrls: ['./all-recipe.component.scss']
})
export class AllRecipeComponent implements OnInit {
  @Output()
  arr: Recipe[];
 id=0;
 categorys:Category[];
  constructor(public recipeser: RecipeSService ,public catser:CategoryService) { }

  ngOnInit() {
    this.recipeser.getAllRecipe().subscribe(s=> {
    this.arr=s;} ,erorr=>{console.log("error")})
    this.catser.getAllCategory().subscribe(s=> {
      this.categorys=s;} ,erorr=>{console.log("error")})
  }

}
