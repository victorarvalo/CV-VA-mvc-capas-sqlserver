import { TestBed } from '@angular/core/testing';

import { SummaryDataServiceService } from './summary-data.service.service';

describe('SummaryDataServiceService', () => {
  let service: SummaryDataServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SummaryDataServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
