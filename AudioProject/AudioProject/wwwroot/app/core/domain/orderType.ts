import {OrderTypeDescription} from "./orderTypeDescription";
export class OrderType {
    Id: number;
    OrderTypeName: string;
    OrderTypeDisplayName: string;
    Price: number;
    PriceFuture: number;
    OrderTypeCategoryId: number;
    SortOrder: number;
    IsActive: boolean;
    IsVisible:boolean;
    OrderTypeDescriptions: Array<OrderTypeDescription>;
}