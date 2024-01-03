import { Component, OnInit } from '@angular/core';
import { MovieService } from 'src/Service/movie.service';
import { iMovieDTO } from 'src/app/Models/iMovieDTO';

@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.css']
})
export class CarouselComponent implements OnInit {
  iMovies: iMovieDTO[] = [];

  constructor(private movieService: MovieService) {}

  ngOnInit(): void {
    this.movieService.getAllActiveMovies().subscribe({
      next: (activeMoviesFromApi) => {
        console.log('next');
        if (activeMoviesFromApi == null) {
          alert('Der findes ingen film.');
        } else {
          // Brug et andet variabelnavn her for at undgå konflikt med movies i næste funktion
          this.iMovies = activeMoviesFromApi;
        }
      },
      error: (error) => {
        console.log(`Der skete en fejl: ${error}`);
      },
    });
  }
}
