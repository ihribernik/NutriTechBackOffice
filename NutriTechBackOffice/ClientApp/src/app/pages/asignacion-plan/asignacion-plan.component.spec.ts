import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { AsignacionPlanComponent } from './asignacion-plan.component';

describe('AsignacionPlanComponent', () => {
  let component: AsignacionPlanComponent;
  let fixture: ComponentFixture<AsignacionPlanComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ AsignacionPlanComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AsignacionPlanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
