import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColorfulListComponent } from './colorful-list.component';

describe('ColorfulListComponent', () => {
  let component: ColorfulListComponent;
  let fixture: ComponentFixture<ColorfulListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ColorfulListComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ColorfulListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
