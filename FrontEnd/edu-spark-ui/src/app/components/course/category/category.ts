import { Component, Input, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { TabsModule } from 'ngx-bootstrap/tabs';

@Component({
  selector: 'app-category',
  standalone: true,
  imports: [FormsModule, CommonModule, RouterModule, TabsModule],
  templateUrl: './category.html',
  styleUrl: './category.css',
})
export class Category implements OnInit {
 // @Input() categories: CourseCategory[] = [];
  @Input() viewType: 'tabs' | 'list' = 'list';

  //selectedCategory: CourseCategory | null = null;

  //constructor(private categoryService:CategoryService) {}

  ngOnInit(): void {
    //this.loadCategories();
  }
}