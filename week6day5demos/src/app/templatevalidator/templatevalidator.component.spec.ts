import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplatevalidatorComponent } from './templatevalidator.component';

describe('TemplatevalidatorComponent', () => {
  let component: TemplatevalidatorComponent;
  let fixture: ComponentFixture<TemplatevalidatorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TemplatevalidatorComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TemplatevalidatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
