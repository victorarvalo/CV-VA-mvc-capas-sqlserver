import { TestBed } from '@angular/core/testing';

import { PersonalDataServiceService } from './personal-data.service.service';

describe('PersonalDataServiceService', () => {
  let service: PersonalDataServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PersonalDataServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
