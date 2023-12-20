import { TestBed } from '@angular/core/testing';

import { ExperienceDataServiceService } from './experience-data.service.service';

describe('ExperienceDataServiceService', () => {
  let service: ExperienceDataServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ExperienceDataServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
