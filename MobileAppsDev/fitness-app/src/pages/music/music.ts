import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { HomePage } from '../home/home';
import { Media, MediaObject } from '@ionic-native/media';
import { FileChooser } from '@ionic-native/file-chooser';
import { FilePath } from '@ionic-native/file-path';
import { File } from '@ionic-native/file';

/**
 * Generated class for the MusicPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-music',
  templateUrl: 'music.html',
})
export class MusicPage {

  fileObj: MediaObject;

  constructor(
    public navCtrl: NavController,
    public navParams: NavParams,
    public media: Media,
    private fileChooser: FileChooser,
    private file: File,
    private filePath: FilePath) {
  }


  ionViewDidLoad() {
    console.log('ionViewDidLoad MusicPage');

  }

  play() {
    var playButton = document.getElementById('play-button');
    var pauseButton = document.getElementById('pause-button');

    this.fileObj = this.media.create('https://www.sample-videos.com/audio/mp3/crowd-cheering.mp3');
    this.fileObj.play();
    playButton.classList.add('display-none');
    pauseButton.classList.remove('display-none');

  }

  chooseSong() {
    var uriTemp;
    this.fileChooser.open().then(uri => {
      console.log("_:_:_:_:_:_:" + uri);
    }).catch(e => {
      console.log("Error opening file: ", e);
    });

  }


  pause() {
    var playButton = document.getElementById('play-button');
    var pauseButton = document.getElementById('pause-button');

    this.fileObj.pause();
    playButton.classList.remove('display-none');
    pauseButton.classList.add('display-none');
  }


  goHome() {
    this.navCtrl.pop();
  }

}
