"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var common_1 = require("@angular/common");
var data_service_1 = require("../../core/services/data.service");
var membership_service_1 = require("../../core/services/membership.service");
var notification_service_1 = require("../../core/services/notification.service");
var account_component_1 = require("./account.component");
var login_component_1 = require("./login.component");
var register_component_1 = require("./register.component");
var routes_1 = require("./routes");
var AccountModule = (function () {
    function AccountModule() {
    }
    return AccountModule;
}());
AccountModule = __decorate([
    core_1.NgModule({
        imports: [
            common_1.CommonModule,
            forms_1.FormsModule,
            routes_1.accountRouting
        ],
        declarations: [
            account_component_1.AccountComponent,
            login_component_1.LoginComponent,
            register_component_1.RegisterComponent
        ],
        providers: [
            data_service_1.DataService,
            membership_service_1.MembershipService,
            notification_service_1.NotificationService
        ]
    })
], AccountModule);
exports.AccountModule = AccountModule;
