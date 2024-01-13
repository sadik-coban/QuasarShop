import { Component } from '@angular/core';
import { IProduct, ProductsService } from './services/products.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styles: [],
})
export class AppComponent {
  constructor(protected readonly productsService: ProductsService) {}

  formData: IProduct = {};
}
