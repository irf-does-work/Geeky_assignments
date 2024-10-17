import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'activeProjectsPipe',
  standalone: true
})
export class ActiveProjectsPipePipe implements PipeTransform {

  transform(value:any): any {
      var resultArray = value.filter((x: { isActive: boolean; })=> x.isActive == true)
      return resultArray;
    }
    

  }

