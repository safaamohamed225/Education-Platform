import { Component, Input, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-about',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './about.html',
  styleUrl: './about.css'
})
export class About implements OnInit{
  @Input() userId = 25;

  

  constructor() {}

  ngOnInit(): void {
    this.getUserProfile();
  }

  getUserProfile() {
    // Fetch user data, for now using static values for demo

  }

}