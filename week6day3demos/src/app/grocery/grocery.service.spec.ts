import { TestBed } from '@angular/core/testing';

import { GroceryService } from './grocery.service';

describe('GroceryService', () => {
  let service: GroceryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GroceryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
