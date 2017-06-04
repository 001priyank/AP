import { Component, OnInit,Injectable } from "@angular/core";
import { OrderService } from "../core/services/order.service";
import {Order} from "../core/domain/order";
import { Paginated } from "../core/common/paginated";
import { Resolve, ActivatedRoute } from "@angular/router";

@Component({
    selector: "order",
    templateUrl: "./app/components/order.component.html"
})

@Injectable()
export class OrderComponent extends Paginated implements OnInit {
    private _orderTypeApi: string = "api/Order/";
    private _orders: Array<Order>;
    private _finalOrders : Array<Order>;
    constructor(public orderService: OrderService) {
        super(0, 0, 0);
    }
    DefaultOrder() {
        this.orderService.getDefaultOrder().subscribe(res => {
            var data: any = res.json();
            console.log('Order data');
            console.log(data);
            this._orders.push(data);
        },
            error => console.error("Error: " + error));
    }
     ngOnInit() {
        this.orderService.set(this._orderTypeApi);
        this._orders = new Array<Order>();
        this._finalOrders = new Array<Order>();
        this.DefaultOrder();
    }
    AddOrder(order: Order) {
        this._finalOrders.push(order);
        this.DefaultOrder();
    }
    
    RemoveAllOrder() {
        while (this._finalOrders.length) { this._finalOrders.pop(); }
        this.orderService.getDefaultOrder().subscribe(res => {
                var data: any = res.json();
                this._orders.push(data.Order);
            },
            error => console.error("Error: " + error));  
    }
    SubmitAllOrders(){
        console.log(this._orders);
    }
}