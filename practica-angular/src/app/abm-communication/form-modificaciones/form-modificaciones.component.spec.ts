import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormModificacionesComponent } from './form-modificaciones.component';

describe('FormModificacionesComponent', () => {
  let component: FormModificacionesComponent;
  let fixture: ComponentFixture<FormModificacionesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormModificacionesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormModificacionesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
