import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FullinformationComponent } from './fullinformation.component';

describe('FullinformationComponent', () => {
  let component: FullinformationComponent;
  let fixture: ComponentFixture<FullinformationComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FullinformationComponent]
    });
    fixture = TestBed.createComponent(FullinformationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
