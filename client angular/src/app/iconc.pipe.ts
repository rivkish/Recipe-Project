import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'iconc'
})
export class IconcPipe implements PipeTransform {

  transform(value: number): string {
    let s="";
 if(value==1)
 s="../../assets/icons/תמונה2.png"
 else if(value==2)
 s="../../assets/icons/תמונה3.png"
 else if(value==3)
 s="../../assets/icons/תמונה1.png"
     return s;
   }

}
