import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCilindroComponent } from './add-cilindro.component';

describe('AddCilindroComponent', () => {
  let component: AddCilindroComponent;
  let fixture: ComponentFixture<AddCilindroComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddCilindroComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddCilindroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
