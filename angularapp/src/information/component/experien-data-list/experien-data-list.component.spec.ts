import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExperienDataListComponent } from './experien-data-list.component';

describe('ExperienDataListComponent', () => {
  let component: ExperienDataListComponent;
  let fixture: ComponentFixture<ExperienDataListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ExperienDataListComponent]
    });
    fixture = TestBed.createComponent(ExperienDataListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
