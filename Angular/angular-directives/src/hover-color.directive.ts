import { Directive, ElementRef, HostListener} from '@angular/core';

@Directive({
  selector: '[appHoverColor]',
  standalone: true
})
export class HoverColorDirective {

  constructor(private elementRef: ElementRef) { 

  }


  @HostListener('mouseenter') mouseOver(){
    this.elementRef.nativeElement.style.backgroundColor ='red';
  }

  @HostListener('mouseleave') mouseLeave(){
    this.elementRef.nativeElement.style.backgroundColor ='';
  }
}
