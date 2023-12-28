import { BaseModel, IBaseModel } from './baseModel';
import { IMovie } from './movie';

export interface ITheme extends IBaseModel {
  movies?: IMovie[];
}

export class Theme extends BaseModel implements ITheme {
  movies?: IMovie[];

  constructor() {
    super();
    this.movies = [];
  }
}
