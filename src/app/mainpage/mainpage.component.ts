
import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-mainpage',
  standalone: true,
  imports: [],
  templateUrl: './mainpage.component.html',

  styleUrl: './mainpage.component.css'
})
export class MainpageComponent {
  constructor(private router: Router
  ) { }
  gachieve(): void {
    // Add your custom logic here
    this.router.navigate(['/achievements']);
  }
  glinks(): void {
    // Add your custom logic here
    this.router.navigate(['/contact']);
  }
}
