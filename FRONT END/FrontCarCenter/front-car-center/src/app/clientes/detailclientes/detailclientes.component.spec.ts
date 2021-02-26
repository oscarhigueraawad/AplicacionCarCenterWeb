import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailclientesComponent } from './detailclientes.component';

describe('DetailclientesComponent', () => {
  let component: DetailclientesComponent;
  let fixture: ComponentFixture<DetailclientesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailclientesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailclientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
