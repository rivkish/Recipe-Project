import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'time'
})
export class TimePipe implements PipeTransform {

  transform(time:number): any {
    let h=Math.floor(time/60);
    let m=time%60;
    if(h==1&&m>0)
    return "שעה ו"+m+" דקות "
    else if(h==1)
    return "שעה"
    else if(h==0)
    return m+ " דקות"
    else if(m==0)
    return h+" שעות"
    else 
    return h+ " שעות ו "+m+ " דקות";
  }

}
