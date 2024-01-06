import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/Service/ApiService.service';
import { iMovieDTO } from 'src/app/Models/iMovieDTO';

@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.css']
})
export class CarouselComponent implements OnInit {
  iMovies: iMovieDTO[] = [];

  constructor(private api: ApiService) {}

  ngOnInit(): void {
    this.api.getAllActiveMovies().subscribe({
      next: (apiResult) => {
        console.log('next');
        if (apiResult == null) {
          alert('Der findes ingen film.');
        } else {
          // Brug et andet variabelnavn her for at undgå konflikt med movies i næste funktion
          this.iMovies = apiResult;
        }
      },
      error: (error) => {
        console.log(`Der skete en fejl: ${error}`);
      },
    });
  }
}
