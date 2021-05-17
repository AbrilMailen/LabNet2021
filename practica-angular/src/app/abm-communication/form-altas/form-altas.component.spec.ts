import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormAltasComponent } from './form-altas.component';

describe('FormAltasComponent', () => {
  let component: FormAltasComponent;
  let fixture: ComponentFixture<FormAltasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormAltasComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormAltasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
