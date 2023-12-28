import { BaseModel, IBaseModel } from './baseModel';
import { ICinema } from './cinema';
import { IMovie } from './movie';

export interface IHall extends IBaseModel {
  row?: number;
  column?: number;
  movies?: IMovie[];
  cinemas?: ICinema[];
}

export class Hall extends BaseModel implements IHall {
  row?: number;
  column?: number;
  movies?: IMovie[];
  cinemas?: ICinema[];

  constructor() {
    super();
    this.movies = [];
    this.cinemas = [];
  }
}
