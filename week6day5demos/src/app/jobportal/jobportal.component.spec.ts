import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JobportalComponent } from './jobportal.component';

describe('JobportalComponent', () => {
  let component: JobportalComponent;
  let fixture: ComponentFixture<JobportalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JobportalComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(JobportalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
