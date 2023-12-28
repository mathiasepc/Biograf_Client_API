import { BaseModel, IBaseModel } from './baseModel';
import { IHall } from './hall';
import { IUser } from './user';

export interface ICinema extends IBaseModel {
  location?: string;
  halls?: IHall[];
  users?: IUser[];
}

export class Cinema extends BaseModel implements ICinema {
  location?: string;
  halls?: IHall[];
  users?: IUser[];

  constructor() {
    super();
    this.halls = [];
    this.users = [];
  }
}
