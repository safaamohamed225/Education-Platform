import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HighlightDirective } from '../../../directive/highlight/highlight';

@Component({
  selector: 'app-directives',
  standalone: true,
  imports: [CommonModule, FormsModule, HighlightDirective],
  templateUrl: './directives.html',
  styleUrl: './directives.css'
})
export class Directives {
// Structural Directives Examples
showContent: boolean = true;
items: string[] = ['Angular', 'React', 'Vue', 'Svelte'];
selectedColor: string = 'red';

// Attribute Directives Examples
isActive: boolean = true;
isHighlighted: boolean = false;
}