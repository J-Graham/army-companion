import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ArmyListInfoComponent } from './army-list-info.component';

describe('ArmyListInfoComponent', () => {
  let component: ArmyListInfoComponent;
  let fixture: ComponentFixture<ArmyListInfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ArmyListInfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ArmyListInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
