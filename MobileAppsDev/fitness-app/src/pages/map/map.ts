import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HomePage } from '../home/home';
import { Geolocation } from '@ionic-native/geolocation';

/**
 * Generated class for the MapPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-map',
  templateUrl: 'map.html',
})
export class MapPage {

  public coords: any = document.getElementById("coords");
  public heading: any = document.getElementById("heading");
  public speed: any = document.getElementById("speed");

  constructor(public navCtrl: NavController, public navParams: NavParams, private geolocation: Geolocation) {
  }

  ionViewDidLoad() {
    var coordHeader = document.getElementById("coords");
    var heading = document.getElementById("heading");
    var speed = document.getElementById("speed");
    console.log('ionViewDidLoad MapPage');


    this.geolocation.getCurrentPosition().then((resp) => {
      coordHeader.innerHTML = resp.coords.latitude + " lat, " + resp.coords.longitude + " long";

      if (resp.coords.heading == 0) {
        heading.innerHTML = "North: " + resp.coords.heading;
      } else if (resp.coords.heading > 0 && resp.coords.heading < 90) {
        heading.innerHTML = "North East: " + resp.coords.heading;
      } else if (resp.coords.heading == 90) {
        heading.innerHTML = "East: " + resp.coords.heading;
      } else if (resp.coords.heading > 90 && resp.coords.heading < 180) {
        heading.innerHTML = "South East: " + resp.coords.heading;
      } else if (resp.coords.heading == 180) {
        heading.innerHTML = "South: " + resp.coords.heading;
      } else if (resp.coords.heading > 180 && resp.coords.heading < 270) {
        heading.innerHTML = "South West: " + resp.coords.heading;
      } else if (resp.coords.heading == 270) {
        heading.innerHTML = "West: " + resp.coords.heading;
      } else if (resp.coords.heading > 270 && resp.coords.heading < 365) {
        heading.innerHTML = "North West: " + resp.coords.heading;
      } else if (resp.coords.heading == null){
        heading.innerHTML = "Couldn't find direction data.";
      }

      if (resp.coords.speed == null) {
        speed.innerHTML = "Couldn't find speed data."
      } else {
        speed.innerHTML = resp.coords.speed + " meters per second";
      }
    }).catch((error) => {
      console.log('Error getting location data', error);
      coordHeader.innerHTML = error;
    });
  }

  goHome() {
    this.navCtrl.pop();
  }

}
