import { Pipe, PipeTransform } from '@angular/core';


@Pipe({
  name: 'icon'
})
export class IconPipe implements PipeTransform {

  transform(value: number): string {
   let s="";
if(value==1)
s="🧡"
else if(value==2)
s="🧡🧡"
else if(value==3)
s="🧡🧡🧡"
    return s;
  }

}
