import { TestBed } from '@angular/core/testing';

import { RecipeSService } from './recipe-s.service';

describe('RecipeSService', () => {
  let service: RecipeSService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RecipeSService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
