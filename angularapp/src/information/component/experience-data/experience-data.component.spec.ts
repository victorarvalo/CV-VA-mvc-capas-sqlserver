import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExperienceDataComponent } from './experience-data.component';

describe('ExperienceDataComponent', () => {
  let component: ExperienceDataComponent;
  let fixture: ComponentFixture<ExperienceDataComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ExperienceDataComponent]
    });
    fixture = TestBed.createComponent(ExperienceDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
