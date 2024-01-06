import { Component, OnInit } from '@angular/core';
import { iMovieDTO } from 'src/app/Models/iMovieDTO';
import { ApiService } from 'src/Service/ApiService.service';

@Component({
  selector: 'app-calendar',
  templateUrl: './calendar.component.html',
  styleUrls: ['./calendar.component.css']
})
export class CalendarComponent implements OnInit {
  iMoviesDTO: iMovieDTO[] = [];
  
  constructor(private api: ApiService){}

  ngOnInit(): void {
    this.api.getAllActiveMovies().subscribe({
      next: (apiResult) =>{
        if(apiResult == null){
          console.log("Der var ingen film.");
        }
        else{
          this.iMoviesDTO = apiResult
        }
      }
    })
  }
}
