import { Directive, Input, TemplateRef, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[appGmailCheck]',
  standalone: true
})
export class GmailCheckDirective {

  @Input() set appGmailCheck(email :string){
    if(email.match('@gmail')){
      this.vcr.createEmbeddedView(this.tRef)
    }
    else{
      this.vcr.clear()
    }
  }

  constructor(private tRef : TemplateRef<string>, private vcr : ViewContainerRef) { }


}
