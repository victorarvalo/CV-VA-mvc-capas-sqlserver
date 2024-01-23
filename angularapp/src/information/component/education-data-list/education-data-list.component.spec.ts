import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EducationDataListComponent } from './education-data-list.component';

describe('EducationDataListComponent', () => {
  let component: EducationDataListComponent;
  let fixture: ComponentFixture<EducationDataListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EducationDataListComponent]
    });
    fixture = TestBed.createComponent(EducationDataListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
