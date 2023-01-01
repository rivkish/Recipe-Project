import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddComponent } from './add/add.component';
import { AllRecipeComponent } from './all-recipe/all-recipe.component';
import { EnterComponent } from './enter/enter.component';
import { FullrComponent } from './fullr/fullr.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  { path: "", component: AllRecipeComponent },
  { path: "all-resipe", component: AllRecipeComponent},
  { path: "enter", component: EnterComponent },
  { path: "add", component: AddComponent },
  { path: "login", component: LoginComponent },
  { path: "fullr", component: FullrComponent },
  { path: "**", component: AllRecipeComponent },
  //  children: [{ path: "course/:id", component: CourseComponent }] },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
