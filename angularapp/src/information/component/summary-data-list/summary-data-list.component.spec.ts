import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SummaryDataListComponent } from './summary-data-list.component';

describe('SummaryDataListComponent', () => {
  let component: SummaryDataListComponent;
  let fixture: ComponentFixture<SummaryDataListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SummaryDataListComponent]
    });
    fixture = TestBed.createComponent(SummaryDataListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
