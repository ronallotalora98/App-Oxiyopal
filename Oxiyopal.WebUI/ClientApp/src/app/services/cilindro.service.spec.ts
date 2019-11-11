import { TestBed } from '@angular/core/testing';

import { CilindroService } from './cilindro.service';

describe('CilindroService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CilindroService = TestBed.get(CilindroService);
    expect(service).toBeTruthy();
  });
});
