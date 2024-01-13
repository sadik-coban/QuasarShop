import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { lastValueFrom } from 'rxjs';
import { apiUrl } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class ProductsService {
  constructor(protected readonly http: HttpClient) {
  }

  products: IProduct[] = [];

  getProducts() {
    lastValueFrom(this.http.get<IProduct[]>(`${apiUrl}/api/products`)).then(
      (response) => {
        this.products = response;
      }
    );
  }
}


export interface IProduct {
  id?: string;
  name?:string;
  price?: number;
  description?: string;
  image?: string;
  catalogs?: ICatalog[];
}

export interface ICatalog {
  id?: string;
  name?:string;
}
