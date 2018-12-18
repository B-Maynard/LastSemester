import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';
import { Pedometer } from '@ionic-native/pedometer';
import { Stepcounter } from '@ionic-native/stepcounter';
import { Media, MediaObject } from '@ionic-native/media';
import { FileChooser } from '@ionic-native/file-chooser';
import { FilePath } from '@ionic-native/file-path';
import { Geolocation } from '@ionic-native/geolocation';
import { File } from '@ionic-native/file';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import { MapPage } from '../pages/map/map';
import { MusicPage } from '../pages/music/music';
import { PreviousWorkoutsPage } from '../pages/previous-workouts/previous-workouts';
@NgModule({
  declarations: [
    MyApp,
    HomePage,
    MapPage,
    MusicPage,
    PreviousWorkoutsPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage,
    MapPage,
    MusicPage,
    PreviousWorkoutsPage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    Pedometer,
    Stepcounter,
    Media,
    FileChooser,
    FilePath,
    Geolocation,
    File,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
