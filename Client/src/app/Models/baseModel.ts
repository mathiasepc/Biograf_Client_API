export interface IBaseModel {
    id: string;
    name: string;
}
  
export class BaseModel implements IBaseModel {
    id: string;
    name: string;

    constructor() {
        this.id! = '';
        this.name! = '';
    }
}
  