import { Component } from '@angular/core';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { PlansAndPricingComponent } from '../plans-and-pricing/plans-and-pricing.component';

@Component({
  selector: 'app-home',
  imports: [CarouselModule, PlansAndPricingComponent],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {

}
