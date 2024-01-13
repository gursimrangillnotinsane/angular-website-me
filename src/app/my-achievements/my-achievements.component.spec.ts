import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyAchievementsComponent } from './my-achievements.component';

describe('MyAchievementsComponent', () => {
  let component: MyAchievementsComponent;
  let fixture: ComponentFixture<MyAchievementsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MyAchievementsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MyAchievementsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
