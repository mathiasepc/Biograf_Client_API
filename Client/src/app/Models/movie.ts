import { IActor } from './actor';
import { BaseModel, IBaseModel } from './baseModel';
import { IHall } from './hall';
import { ITheme } from './theme';

export interface IMovie extends IBaseModel {
  length?: number;
  release?: Date;
  actors?: IActor[];
  halls?: IHall[];
  themes?: ITheme[];
}

export class Movie extends BaseModel implements IMovie {
  length?: number;
  release?: Date;
  actors?: IActor[];
  halls?: IHall[];
  themes?: ITheme[];

  constructor() {
    super();
    this.actors = [];
    this.halls = [];
    this.themes = [];
  }
}
