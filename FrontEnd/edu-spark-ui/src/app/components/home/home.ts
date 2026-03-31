import { Component } from '@angular/core';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { PlansAndPicing } from '../plans-and-picing/plans-and-picing';

@Component({
  selector: 'app-home',
  imports: [CarouselModule, PlansAndPicing],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {

}
