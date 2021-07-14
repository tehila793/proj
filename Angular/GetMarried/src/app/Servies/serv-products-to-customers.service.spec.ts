import { TestBed } from '@angular/core/testing';

import { ServProductsToCustomersService } from './serv-products-to-customers.service';

describe('ServProductsToCustomersService', () => {
  let service: ServProductsToCustomersService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServProductsToCustomersService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
