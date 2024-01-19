import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonalReferenceDataComponent } from './personal-reference-data.component';

describe('PersonalReferenceDataComponent', () => {
  let component: PersonalReferenceDataComponent;
  let fixture: ComponentFixture<PersonalReferenceDataComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PersonalReferenceDataComponent]
    });
    fixture = TestBed.createComponent(PersonalReferenceDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
