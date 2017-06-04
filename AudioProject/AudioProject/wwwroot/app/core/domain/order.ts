import {OrderItem} from "./orderItem";
import {OrderFile} from "./orderFile";

export class Order {
    Id: number;
    UserId: number;
    OrderStatus: number ;
    OrderItems: Array<OrderItem>;
    OrderFiles: Array<OrderFile>;
}