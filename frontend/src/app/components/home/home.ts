import { Component } from '@angular/core';
import { CarouselModule } from 'ngx-bootstrap/carousel';

@Component({
  selector: 'app-home',
  standalone: true, 
  imports: [CarouselModule],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {

}
