import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OldCilindrosComponent } from './old-cilindros.component';

describe('OldCilindrosComponent', () => {
  let component: OldCilindrosComponent;
  let fixture: ComponentFixture<OldCilindrosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OldCilindrosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OldCilindrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
