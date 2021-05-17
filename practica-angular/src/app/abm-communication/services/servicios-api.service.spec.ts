import { TestBed } from '@angular/core/testing';

import { ServiciosAPIService } from './servicios-api.service';

describe('ServiciosAPIService', () => {
  let service: ServiciosAPIService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServiciosAPIService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
