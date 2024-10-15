import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'activeProjectsPipe',
  standalone: true
})
export class ActiveProjectsPipePipe implements PipeTransform {

  transform(value:string, projectStatus : boolean): any {
    if (projectStatus ==true ){
      return value;
    }
  }

}
