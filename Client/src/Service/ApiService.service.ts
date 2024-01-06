import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { enviroment } from 'src/app/Enviroment/Enviroment';
import { iMovieDTO } from 'src/app/Models/iMovieDTO';

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private baseUrl = enviroment.APIUrl;

  constructor(private http: HttpClient) { }

  getModelData(model: string): Observable<any> {
    const url = this.constructModelUrl(model);
    return this.http.get(url);
  }

  private constructModelUrl(model: string): string {
    switch (model) {
      case 'actor':
        return this.baseUrl + 'Actor';
      case 'cinema':
        return this.baseUrl + 'Cinema';
      case 'hall':
        return this.baseUrl + 'Hall';
      case 'movie':
        return this.baseUrl + 'Movie';
        case 'date':
        return this.baseUrl + 'ReleaseDate';
        case 'theme':
        return this.baseUrl + 'Theme';
        case 'user':
        return this.baseUrl + 'User';
      default:
        throw new Error('Ugyldig model valgt');
    }
  }

  getAllActiveMovies(): Observable<iMovieDTO[]>{
    return this.http.get<iMovieDTO[]>(this.baseUrl +  'Movie');
  }
}