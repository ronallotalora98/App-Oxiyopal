import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListCilindrosComponent } from './list-cilindros.component';

describe('ListCilindrosComponent', () => {
  let component: ListCilindrosComponent;
  let fixture: ComponentFixture<ListCilindrosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListCilindrosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListCilindrosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
