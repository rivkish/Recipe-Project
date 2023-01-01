import { Pipe, PipeTransform } from '@angular/core';
import { Recipe } from 'src/models/Recipe';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  
  transform(arr: Recipe[],txt: number): any {
    let c1:Recipe[]=[];
    for(let i=0;i<arr.length;i++){
      if(arr[i].CategoryId==txt||txt==0)
      c1.push(arr[i]);
    }
  return c1;
  }

}
