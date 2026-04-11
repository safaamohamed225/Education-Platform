import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-directive',
  imports: [CommonModule],
  standalone: true,         
  templateUrl: './directive.html',
  styleUrl: './directive.css',
})
export class Directive {

}
