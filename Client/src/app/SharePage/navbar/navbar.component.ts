import { Component } from '@angular/core';
// Importerer Angular's DomSanitizer
// import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})

export class NavbarComponent {
  logo = 'assets/img/Biograf_Logo.png';

  // // Constructor, hvor DomSanitizer injiceres
  // constructor(private sanitizer: DomSanitizer) {}

  // getSanitizedImage(){
  //   return this.sanitizer.bypassSecurityTrustUrl(this.logo);
  // }
}
