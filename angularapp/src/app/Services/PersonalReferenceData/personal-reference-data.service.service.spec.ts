import { TestBed } from '@angular/core/testing';

import { PersonalReferenceDataServiceService } from './personal-reference-data.service.service';

describe('PersonalReferenceDataServiceService', () => {
  let service: PersonalReferenceDataServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PersonalReferenceDataServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
