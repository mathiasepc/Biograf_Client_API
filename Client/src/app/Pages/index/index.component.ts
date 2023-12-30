import { Component, OnInit } from '@angular/core';
import { MovieService } from 'src/Service/movie.service';
import { iMovieDTO } from 'src/app/Models/iMovieDTO';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit{
  // movie = [
  //   { id: 1, title: 'Oppenheimer', imageUrl: 'assets/img/Oppenheimer.jpg' },
  //   { id: 2, title: 'Guardian of the galaxy', imageUrl: 'assets/img/GOTG.jpg' },
  //   { id: 3, title: 'Barbie', imageUrl: 'assets/img/Barbie.jpg' },
  //   // ... andre film ...
  // ];

iMovies: iMovieDTO[] = [];

constructor(private movieService: MovieService) {}

ngOnInit(): void {

  this.movieService.getAll().subscribe({
    next: (moviesFromApi) => {
      console.log("next");
      if (moviesFromApi == null) {
        alert('Der findes ingen film.');
      } else {
        moviesFromApi.forEach(movie => console.log(`id: ${movie.id} navn: ${movie.name} img: ${movie.imgURL }`));
        // Brug et andet variabelnavn her for at undgå konflikt med movies i næste funktion
        this.iMovies = moviesFromApi;
      }
    },
    error: (error) => {
      console.log(`Der skete en fejl: ${error}`);
    },
  });
}

}
