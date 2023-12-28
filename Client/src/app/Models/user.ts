import { BaseModel, IBaseModel } from './baseModel';
import { ICinema } from './cinema';

export interface IUser extends IBaseModel {
  lastName?: string;
  age?: number;
  email?: string;
  cinemas?: ICinema[];
}

export class User extends BaseModel implements IUser {
  lastName?: string;
  age?: number;
  email?: string;
  cinemas?: ICinema[];

  constructor() {
    super();
    this.cinemas = [];
  }
}
