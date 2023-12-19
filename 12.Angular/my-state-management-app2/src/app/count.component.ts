import { Component } from "@angular/core";
import { CountService } from "./count.service";

@Component({
    standalone: true,
    selector: "app-count",
    template: `
    <h1>{{c.count}}</h1>
    `
})
export class CountComponent{
    constructor(public c:CountService){}
}