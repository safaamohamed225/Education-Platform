import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CourseService } from '../../../services/course.service';

@Component({
  selector: 'app-course-details',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    RouterModule,
  ],
  templateUrl: './course-details.html',
  styleUrl: './course-details.css',
})
export class CourseDetails implements OnInit {

  courseDetails: any = null;   
  videoUrl: string | null = null;
  courseId!: number;

  activeSessions: Set<number> = new Set<number>();
  isLoggedIn = false;
  userId = 0;

  constructor(
    private route: ActivatedRoute,
    private courseService: CourseService
  ) {}

  ngOnInit(): void {
    this.courseId = Number(this.route.snapshot.paramMap.get('id'));

    this.loadCourseDetails();
  }

  loadCourseDetails(): void {
    this.courseService.getCourseDetails(this.courseId).subscribe((data) => {
      this.courseDetails = data;
    });
  }
}