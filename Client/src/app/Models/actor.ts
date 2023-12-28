import { BaseModel, IBaseModel } from './baseModel';
import { IMovie } from './movie';

export interface IActor extends IBaseModel {
  age?: number;
  movies?: IMovie[];
}

export class Actor extends BaseModel implements IActor {
  age?: number;
  movies?: IMovie[];

  constructor() {
    super();
    this.movies = [];
  }
}
