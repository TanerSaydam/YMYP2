import { ProductModel } from "./product.model";

export class OrderDetailModel{
    id: number = 0;
    productId: number = 0;
    price: number = 0;
    quantity: number = 0;
    product: ProductModel = new ProductModel();
  }