import { ProductModel } from "./product.model";

export class ShoppingCartModel{
    id: number = 0;
    productId: number = 0;
    product: ProductModel = new ProductModel();
    quantity: number = 0;
}