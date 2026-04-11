import { Component } from '@angular/core';
import { BrowseCourse } from "../browse-course/browse-course";
import { ActivatedRoute, Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-course-by-category',
  standalone: true,
  imports: [BrowseCourse, FormsModule, CommonModule],
  templateUrl: './course-by-category.html',
  styleUrl: './course-by-category.css'
})
export class CourseByCategoryComponent {
  categoryId: number = 0;

  constructor(private route: ActivatedRoute, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.categoryId = Number(params.get('categoryId')); // or 'categoryId' depending on your route configuration           
    });
  }
}