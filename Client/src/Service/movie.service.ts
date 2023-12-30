import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { enviroment } from 'src/app/Enviroment/Enviroment';
import { iMovieDTO } from 'src/app/Models/iMovieDTO';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private apiUrl = enviroment.APIUrl;

  constructor(private http: HttpClient) { }

  getAll(): Observable<iMovieDTO[]>{
    return this.http.get<iMovieDTO[]>(this.apiUrl +  'Movie/GetAllMoviesWithThemes');
  }
}