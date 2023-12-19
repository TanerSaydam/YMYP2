import { Component } from "@angular/core";
import { CountService } from "./count.service";

@Component({
    selector: "app-operations",
    standalone: true,
    template: `
    <button (click)="c.increment()">+</button>
    <button (click)="c.decrement()">-</button>
    
    `
})
export class OperationsComponent{
    constructor(public c:CountService){}
}