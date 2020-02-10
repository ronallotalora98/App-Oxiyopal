import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditCilindrosComponent } from './edit-cilindros.component';

describe('EditCilindrosComponent', () => {
  let component: EditCilindrosComponent;
  let fixture: ComponentFixture<EditCilindrosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditCilindrosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditCilindrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
