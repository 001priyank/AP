import {OrderType} from "./orderType";

export class OrderTypeCategory {
    Id:number;
    CategoryName: string;
    CategoryDescription: string;
    SortOrder: number;
    IsActive: boolean;
    IsVisible:boolean;
    OrderTypes: Array<OrderType>;
}