import { Component, OnInit } from '@angular/core';
import { MovieService } from 'src/Service/movie.service';
import { iMovieDTO } from 'src/app/Models/iMovieDTO';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css'],
})
export class IndexComponent implements OnInit {
  iMovies: iMovieDTO[] = [];

  constructor(private movieService: MovieService) {}

  ngOnInit(): void {
    this.movieService.getAll().subscribe({
      next: (moviesFromApi) => {
        console.log('next');
        if (moviesFromApi == null) {
          alert('Der findes ingen film.');
        } else {
          moviesFromApi.forEach((movie) =>
            console.log(
              `idAPI: ${movie.id} navnAPI: ${movie.name} imgAPI: ${movie.imgURL}`
            )
          );
          // Brug et andet variabelnavn her for at undgå konflikt med movies i næste funktion
          this.iMovies = moviesFromApi;

          this.iMovies.forEach((movie) =>
            console.log(
              `id: ${movie.id} navn: ${movie.name} img: ${movie.imgURL}`
            )
          );
        }
      },
      error: (error) => {
        console.log(`Der skete en fejl: ${error}`);
      },
    });
  }
}
