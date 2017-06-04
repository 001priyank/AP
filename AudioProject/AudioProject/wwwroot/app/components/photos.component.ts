import { Component, OnInit } from '@angular/core';
import { Photo } from '../core/domain/photo';
import { Paginated } from '../core/common/paginated';
import { DataService } from '../core/services/data.service';
import { OrderTypeCategory } from "../core/domain/orderTypeCategory";

@Component({
    selector: 'photos',
    templateUrl: './app/components/photos.component.html'
})
export class PhotosComponent extends Paginated implements OnInit {
    private _photosAPI: string = 'api/OrderType/';
    private _orderTypeCategories: Array<OrderTypeCategory>;

    constructor(public photosService: DataService) {
        super(0, 0, 0);
    }

    ngOnInit() {         
        this.getPhotos();
    }

    getPhotos(): void {
        let self = this;
        self.photosService.getAll()
            .subscribe(res => {

                var data: any = res.json();

                self._orderTypeCategories = data.OrderTypeCategories;
               
            },
            error => console.error('Error: ' + error));
    }

    search(i: any): void {
        super.search(i);
        this.getPhotos();
    };
}