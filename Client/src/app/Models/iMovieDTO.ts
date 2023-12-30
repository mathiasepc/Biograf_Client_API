import { BaseModel, IBaseModel } from "./baseModel";
import { ITheme } from "./theme";

export interface iMovieDTO extends IBaseModel {
    release?: string;
    length?: number;
    imgURL?: string;
    themes?: ITheme[];
}

export class MovieDTO extends BaseModel implements iMovieDTO{
    release?: string;
    length?: number;
    imgUimgURLrl?: string;
    themes?: ITheme[];

    constructor(){
        super();
        this.themes = [];   
    }
}