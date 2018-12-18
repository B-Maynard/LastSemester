import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HomePage } from '../home/home';

/**
 * Generated class for the PreviousWorkoutsPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-previous-workouts',
  templateUrl: 'previous-workouts.html',
})
export class PreviousWorkoutsPage {

  public previousWorkouts: any;

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad PreviousWorkoutsPage');

    const promise = new Promise((resolve, reject) => {
      resolve(JSON.parse(localStorage.getItem('previousworkouts.json')));
    });

    promise.then((previousWorkouts) => {
      this.previousWorkouts = previousWorkouts;
    });
  }

  goHome() {
    this.navCtrl.pop();
  }

  clearPreviousWorkouts() {
    localStorage.removeItem('previousworkouts.json');
    this.navCtrl.pop();
  }

}
