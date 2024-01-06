import { Component } from '@angular/core';
import { Router } from '@angular/router';
// Importerer Angular's DomSanitizer
// import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})

export class NavbarComponent {
  logo = 'assets/img/Biograf_Logo.png';

  constructor(private router: Router) {}

  onSelectChange(event: any) {
    const selectedValue = event.target.value;

    // Naviger til '/admin', hvis 'Admin' er valgt
    if (selectedValue === 'admin') {
      this.router.navigate(['/admin']);
    }
  }
}

