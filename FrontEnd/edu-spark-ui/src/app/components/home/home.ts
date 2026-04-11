import { Component } from '@angular/core';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { PlansAndPricing } from '../plans-and-picing/plans-and-pricing';
import { CommonModule } from '@angular/common';
import { Category } from '../course/category/category';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CarouselModule, PlansAndPricing, CommonModule, Category],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {

}
