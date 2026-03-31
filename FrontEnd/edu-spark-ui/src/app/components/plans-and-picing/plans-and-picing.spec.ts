import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PlansAndPicing } from './plans-and-picing';

describe('PlansAndPicing', () => {
  let component: PlansAndPicing;
  let fixture: ComponentFixture<PlansAndPicing>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PlansAndPicing]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PlansAndPicing);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
