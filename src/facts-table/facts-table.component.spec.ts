import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FactsTableComponent } from './facts-table.component';

describe('FactsTableComponent', () => {
  let component: FactsTableComponent;
  let fixture: ComponentFixture<FactsTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FactsTableComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FactsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
