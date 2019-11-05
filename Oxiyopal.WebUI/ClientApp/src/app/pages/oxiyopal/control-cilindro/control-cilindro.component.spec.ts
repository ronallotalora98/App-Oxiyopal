import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ControlCilindroComponent } from './control-cilindro.component';

describe('ControlCilindroComponent', () => {
  let component: ControlCilindroComponent;
  let fixture: ComponentFixture<ControlCilindroComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ControlCilindroComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ControlCilindroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
