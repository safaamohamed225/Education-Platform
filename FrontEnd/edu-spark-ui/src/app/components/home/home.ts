import { Component } from '@angular/core';
import { CarouselModule } from 'ngx-bootstrap/carousel';
import { PlansAndPicing } from '../plans-and-picing/plans-and-picing';
import { CommonModule } from '@angular/common';
import { Category } from '../course/category/category';

@Component({
  selector: 'app-home',
  imports: [CarouselModule, PlansAndPicing, CommonModule, Category],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {

}
