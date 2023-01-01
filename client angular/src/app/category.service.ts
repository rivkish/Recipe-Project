import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from 'src/models/Category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  getAllCategory(){
    return this.myHttp.get<Category[]>("  https://localhost:44336/api/category/GetAllCategories");
  }

  constructor(public myHttp:HttpClient) { }
}
