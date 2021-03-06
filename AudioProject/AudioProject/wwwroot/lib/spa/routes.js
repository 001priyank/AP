"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var home_component_1 = require("./components/home.component");
var photos_component_1 = require("./components/photos.component");
var albums_component_1 = require("./components/albums.component");
var album_photos_component_1 = require("./components/album-photos.component");
var order_type_component_1 = require("./components/order-type.component");
var order_component_1 = require("./components/order.component");
var appRoutes = [
    {
        path: "",
        redirectTo: "/home",
        pathMatch: "full"
    },
    {
        path: "home",
        component: home_component_1.HomeComponent
    },
    {
        path: "ordertype",
        component: order_type_component_1.OrderTypeComponent
    },
    {
        path: "order",
        component: order_component_1.OrderComponent
    },
    {
        path: "photos",
        component: photos_component_1.PhotosComponent
    },
    {
        path: "albums",
        component: albums_component_1.AlbumsComponent
    },
    {
        path: "albums/:id/photos",
        component: album_photos_component_1.AlbumPhotosComponent
    }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
