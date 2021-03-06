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
var data_service_1 = require("../core/services/data.service");
var paginated_1 = require("../core/common/paginated");
var OrderTypeComponent = (function (_super) {
    __extends(OrderTypeComponent, _super);
    function OrderTypeComponent(orderTypeService) {
        var _this = _super.call(this, 0, 0, 0) || this;
        _this.orderTypeService = orderTypeService;
        _this._orderTypeApi = "api/OrderType/";
        return _this;
    }
    OrderTypeComponent.prototype.ngOnInit = function () {
        this.orderTypeService.set(this._orderTypeApi);
        this.getAllOrderCategories();
    };
    OrderTypeComponent.prototype.getAllOrderCategories = function () {
        var self = this;
        self.orderTypeService.getAll()
            .subscribe(function (res) {
            var data = res.json();
            self._orderTypeCategories = data.OrderTypeCategories;
        }, function (error) { return console.error("Error: " + error); });
    };
    return OrderTypeComponent;
}(paginated_1.Paginated));
OrderTypeComponent = __decorate([
    core_1.Component({
        selector: "order-type",
        templateUrl: "./app/components/order-type.component.html"
    }),
    core_1.Injectable(),
    __metadata("design:paramtypes", [data_service_1.DataService])
], OrderTypeComponent);
exports.OrderTypeComponent = OrderTypeComponent;
//# sourceMappingURL=order-type.component.js.map