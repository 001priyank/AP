import {OrderType} from "./orderType";

export class OrderItem {
    id: number;
    OrderTypeId: number;
    OrderType: OrderType;
    Description: string;
    OrderStatus: number;
    OrderId: number;
    CompletionPercent: number;
    Selected: boolean;
}