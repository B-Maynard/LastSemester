import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PreviousWorkoutsPage } from './previous-workouts';

@NgModule({
  declarations: [
    PreviousWorkoutsPage,
  ],
  imports: [
    IonicPageModule.forChild(PreviousWorkoutsPage),
  ],
})
export class PreviousWorkoutsPageModule {}
