import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoogleLinksComponent } from './google-links.component';

describe('GoogleLinksComponent', () => {
  let component: GoogleLinksComponent;
  let fixture: ComponentFixture<GoogleLinksComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GoogleLinksComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GoogleLinksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
