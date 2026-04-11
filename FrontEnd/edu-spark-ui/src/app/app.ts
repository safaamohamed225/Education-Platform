import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Home } from './components/home/home';
import { NavBar } from './components/core/nav-bar/nav-bar';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    NavBar,
    Home
  ],
  templateUrl: './app.html',
  styleUrl: './app.css',
 })
export class App  {
  title = 'online-course';
  isIframe = false;
  constructor() {}

  ngOnInit(): void {
    this.isIframe = window !== window.parent && !window.opener; // Remove this line to use Angular Universal
  }

  getRouteAnimationData(outlet: RouterOutlet) {
    return outlet && outlet.activatedRouteData;// && outlet.activatedRouteData['animation'];
  }
}