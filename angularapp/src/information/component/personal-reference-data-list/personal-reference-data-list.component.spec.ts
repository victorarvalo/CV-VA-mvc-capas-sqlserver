import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonalReferenceDataListComponent } from './personal-reference-data-list.component';

describe('PersonalReferenceDataListComponent', () => {
  let component: PersonalReferenceDataListComponent;
  let fixture: ComponentFixture<PersonalReferenceDataListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PersonalReferenceDataListComponent]
    });
    fixture = TestBed.createComponent(PersonalReferenceDataListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
