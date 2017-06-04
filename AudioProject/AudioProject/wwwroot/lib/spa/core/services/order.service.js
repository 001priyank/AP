"use strict";
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
var http_1 = require("@angular/http");
var core_1 = require("@angular/core");
var OrderService = (function () {
    function OrderService(http) {
        this.http = http;
    }
    OrderService.prototype.set = function (baseUri, pageSize) {
        this._baseUri = baseUri;
        this._pageSize = pageSize;
    };
    OrderService.prototype.getAll = function (url) {
        var uri = this._baseUri + "/";
        return this.http.get(uri)
            .map(function (response) { return response; });
    };
    OrderService.prototype.getDefaultOrder = function () {
        var uri = this._baseUri + "GetDefaultOrder";
        return this.http.get(uri)
            .map(function (response) { return response; });
    };
    OrderService.prototype.get = function (page) {
        var uri = this._baseUri + page.toString() + "/" + this._pageSize.toString();
        return this.http.get(uri)
            .map(function (response) { return response; });
    };
    OrderService.prototype.post = function (data, mapJson) {
        if (mapJson === void 0) { mapJson = true; }
        if (mapJson) {
            return this.http.post(this._baseUri, data)
                .map(function (response) { return response.json(); });
        }
        else {
            return this.http.post(this._baseUri, data);
        }
    };
    OrderService.prototype.delete = function (id) {
        return this.http.delete(this._baseUri + "/" + id.toString())
            .map(function (response) { return response.json(); });
    };
    OrderService.prototype.deleteResource = function (resource) {
        return this.http.delete(resource)
            .map(function (response) { return response.json(); });
    };
    return OrderService;
}());
OrderService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], OrderService);
exports.OrderService = OrderService;
