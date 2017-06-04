"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var order_service_1 = require("../core/services/order.service");
var paginated_1 = require("../core/common/paginated");
var OrderComponent = (function (_super) {
    __extends(OrderComponent, _super);
    function OrderComponent(orderService) {
        var _this = _super.call(this, 0, 0, 0) || this;
        _this.orderService = orderService;
        _this._orderTypeApi = "api/Order/";
        return _this;
    }
    OrderComponent.prototype.DefaultOrder = function () {
        var _this = this;
        this.orderService.getDefaultOrder().subscribe(function (res) {
            var data = res.json();
            console.log('Order data');
            console.log(data);
            _this._orders.push(data);
        }, function (error) { return console.error("Error: " + error); });
    };
    OrderComponent.prototype.ngOnInit = function () {
        this.orderService.set(this._orderTypeApi);
        this._orders = new Array();
        this._finalOrders = new Array();
        this.DefaultOrder();
    };
    OrderComponent.prototype.AddOrder = function (order) {
        this._finalOrders.push(order);
        this.DefaultOrder();
    };
    OrderComponent.prototype.RemoveAllOrder = function () {
        var _this = this;
        while (this._finalOrders.length) {
            this._finalOrders.pop();
        }
        this.orderService.getDefaultOrder().subscribe(function (res) {
            var data = res.json();
            _this._orders.push(data.Order);
        }, function (error) { return console.error("Error: " + error); });
    };
    OrderComponent.prototype.SubmitAllOrders = function () {
        console.log(this._orders);
    };
    return OrderComponent;
}(paginated_1.Paginated));
OrderComponent = __decorate([
    core_1.Component({
        selector: "order",
        templateUrl: "./app/components/order.component.html"
    }),
    core_1.Injectable(),
    __metadata("design:paramtypes", [order_service_1.OrderService])
], OrderComponent);
exports.OrderComponent = OrderComponent;
