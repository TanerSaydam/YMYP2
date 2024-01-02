import { OrderDetailModel } from "./order-detail.model";

export class OrderModel{
    id: number = 0;
    number: string = "";
    date: string = "";
    expectedArrival: string = "";
    cargoCompany: string = "";
    cargoTrackingNumber: string = "";
    details: OrderDetailModel[] = [];
  }