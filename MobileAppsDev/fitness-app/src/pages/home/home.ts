import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { MapPage } from '../map/map';
import { MusicPage } from '../music/music';
import { PreviousWorkoutsPage } from '../previous-workouts/previous-workouts';
import { Stepcounter } from '@ionic-native/stepcounter';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})

export class HomePage {

  //class variables for use in passing to json file
  public interval: any;
  public hours: any;
  public minutes: any;
  public seconds: any;

  constructor(public navCtrl: NavController, public stepCounter: Stepcounter) {

  }

  goToMusic() {
    this.navCtrl.push(MusicPage);
  }

  goToMap() {
    this.navCtrl.push(MapPage);
  }

  goToPreviousWorkouts() {
    this.navCtrl.push(PreviousWorkoutsPage);
  }



  trackingFunction():any {
    var startButton = document.getElementById("play-icon");
    var stopWatch = document.getElementById("stopwatch");
    var mileCounter = document.getElementById("mile-counter")
    var seconds = 0;
    var minutes = 0;
    var hours = 0;
    var startingOffset = 0; //used in native step counter
    var steps = 0;
    var milePercent;

    if (startButton.style.display != "none") {

      //get rid of the play button in order to show the clock
      startButton.style.display = "none";
      stopWatch.style.opacity = "1";
      stopWatch.innerHTML = "00:00:00";

      //Start the step counter (only works on real device, really)
      this.stepCounter.start(startingOffset).then(
        onSuccess => console.log('stepcounter-start success', onSuccess),
        onFailure => console.log('stepcounter-start error', onFailure)
      );


      this.interval = setInterval(function stopWatchLogic() {
        //plus one second, every second. Increments to next time position as necessary
        seconds++;
        if (seconds == 60) {
          minutes++;
          seconds = 0;
          if (minutes == 60) {
              hours++;
              minutes = 0;
          }
        }
        //pads the clock with leading zeroes cause I like it
        stopWatch.innerHTML = pad(hours, 2) + ":" + pad(minutes, 2) + ":" + pad(seconds, 2);

        //pushes the current times to the class level variables for use in json file
        this.seconds = seconds;
        this.minutes = minutes;
        this.hours = hours;
        //Cheated in steps cause step counter doesn't work on emulator
        steps = steps + 15;

        //Calculates the percentage of mile completed based on how many steps taken
        milePercent = ((steps / 2000)).toFixed(2);
        mileCounter.innerHTML = milePercent + " mi";

      }, 1000);
    }
    else {
      var runDataArray = [];
      var runData;
      var runDataString;
      var existingJsonData;

      //clears the current time interval
      clearInterval(this.interval);
      //stops the current stepcounter and would return the total steps counted
      this.stepCounter.stop().then(
        onSuccess => console.log('stepcounter-stop success', onSuccess),
        onFailure => console.log('stepcounter-stop error', onFailure)
      );
      //hide the timer. wouldn't work unless i put it in a timeout
      setTimeout(function() {
        stopWatch.style.opacity = "0";
      }, 10);
      startButton.style.display = "";

      //get current time and distance data from most recent workout
      runData = {"time" : stopWatch.innerHTML,
                 "distance" : mileCounter.innerHTML};
      //add current data to array
      runDataArray.push(runData);


      //checks to see if the json file already exists
      if (localStorage.getItem('previousworkouts.json')) {
        //some fancy stuff needed to append a json file
        runDataString = JSON.stringify(runDataArray);

        existingJsonData = JSON.parse(localStorage.getItem('previousworkouts.json'));
        existingJsonData.unshift(runData);

        localStorage.setItem('previousworkouts.json', JSON.stringify(existingJsonData));

      }
      else {
        //creates the json file if it doesn't exist
        runDataString = JSON.stringify(runDataArray);
        localStorage.setItem('previousworkouts.json', runDataString);
      }

      console.log(JSON.parse(localStorage.getItem('previousworkouts.json')))

      mileCounter.innerHTML = "0.00 mi";

    }


  }



}

//my simple padding function
function pad(num, size) {
    var s = num + "";
    while (s.length < size) s = "0" + s;
    return s;
  }
