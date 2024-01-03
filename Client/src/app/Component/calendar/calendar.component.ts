import { Component, OnInit } from '@angular/core';
import { iMovieDTO } from 'src/app/Models/iMovieDTO';
import { MovieService } from 'src/Service/movie.service';

@Component({
  selector: 'app-calendar',
  templateUrl: './calendar.component.html',
  styleUrls: ['./calendar.component.css']
})
export class CalendarComponent implements OnInit {
  iMoviesDTO: iMovieDTO[] = [];
  
  constructor(private movieService: MovieService){}

  ngOnInit(): void {
    this.movieService.getAllActiveMovies().subscribe({
      next: (activeMoviesAPI) =>{
        if(activeMoviesAPI == null){
          console.log("Der var ingen film.");
        }
        else{
          this.iMoviesDTO = activeMoviesAPI
        }
      }
    })
  }
}
