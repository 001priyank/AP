import { Component, OnInit,Injectable } from "@angular/core";
import { DataService } from "../core/services/data.service";
import {OrderTypeCategory} from "../core/domain/orderTypeCategory";
import { Paginated } from '../core/common/paginated';
import { Resolve, ActivatedRoute } from '@angular/router';

@Component({
    selector: "order-type",
    templateUrl: "./app/components/order-type.component.html"
})

@Injectable()
export class OrderTypeComponent extends Paginated implements OnInit {
    private _orderTypeApi: string = "api/OrderType/";
    private _orderTypeCategories: Array<OrderTypeCategory>;
    constructor(public orderTypeService: DataService) {
        super(0, 0, 0);
    }
     ngOnInit() {
        this.orderTypeService.set(this._orderTypeApi);
        this.getAllOrderCategories();
    }

getAllOrderCategories() {
     let self = this;
        self.orderTypeService.getAll()
            .subscribe(res => {
                var data: any = res.json();
                self._orderTypeCategories = data.OrderTypeCategories;
            },
            error => console.error("Error: " + error));
}

}