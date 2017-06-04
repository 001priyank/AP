﻿import { ModuleWithProviders }  from "@angular/core";
import { Routes, RouterModule } from "@angular/router";

import { HomeComponent } from "./components/home.component";
import { PhotosComponent } from "./components/photos.component";
import { AlbumsComponent } from "./components/albums.component";
import { AlbumPhotosComponent } from "./components/album-photos.component";
import { accountRoutes, accountRouting } from "./components/account/routes";
import { OrderTypeComponent } from "./components/order-type.component";
import { OrderComponent } from "./components/order.component";

const appRoutes: Routes = [
    {
        path: "",
        redirectTo: "/home",
        pathMatch: "full"
    },
    {
        path: "home",
        component: HomeComponent
    },
    {
        path: "ordertype",
        component: OrderTypeComponent
    },
    {
        path: "order",
        component: OrderComponent
    },
    {
        path: "photos",
        component: PhotosComponent
    },
    {
        path: "albums",
        component: AlbumsComponent
    },
    {
        path: "albums/:id/photos",
        component: AlbumPhotosComponent
    }
];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);
