import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OxiyopalLayaudComponent } from './oxiyopal-layaud.component';

describe('OxiyopalLayaudComponent', () => {
  let component: OxiyopalLayaudComponent;
  let fixture: ComponentFixture<OxiyopalLayaudComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OxiyopalLayaudComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OxiyopalLayaudComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
