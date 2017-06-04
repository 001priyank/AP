import { Component } from "@angular/core";
import { OrderTypeComponent } from "./order-type.component";

@Component({
    selector: "home",
    templateUrl: "./app/components/home.component.html",
    providers: [OrderTypeComponent]
})

export class HomeComponent {

    constructor(private orderTypeComponent: OrderTypeComponent) {

    }
}