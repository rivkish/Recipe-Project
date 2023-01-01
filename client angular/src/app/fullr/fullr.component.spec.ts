import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FullrComponent } from './fullr.component';

describe('FullrComponent', () => {
  let component: FullrComponent;
  let fixture: ComponentFixture<FullrComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FullrComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FullrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
