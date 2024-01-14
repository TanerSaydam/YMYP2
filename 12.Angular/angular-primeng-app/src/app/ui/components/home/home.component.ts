import { Component } from '@angular/core';
import { CarouselModule } from 'primeng/carousel';
import { ButtonModule } from 'primeng/button';
import { TagModule } from 'primeng/tag';
import { InputTextModule } from 'primeng/inputtext';
import { CardModule } from 'primeng/card';

export interface Product{
  image: string;
  name: string;
  price: number;
  inventoryStatus: string;
}

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CarouselModule, ButtonModule,TagModule,InputTextModule,CardModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  products: Product[] = [
    {
      image: "https://primefaces.org/cdn/primeng/images/demo/product/bamboo-watch.jpg",
      name: "Bamboo Watch",
      price: 65,
      inventoryStatus: "INSTOCK"
    },
    {
      image: "https://primefaces.org/cdn/primeng/images/demo/product/bamboo-watch.jpg",
      name: "Bamboo Watch",
      price: 65,
      inventoryStatus: "INSTOCK"
    },
    {
      image: "https://primefaces.org/cdn/primeng/images/demo/product/bamboo-watch.jpg",
      name: "Bamboo Watch",
      price: 65,
      inventoryStatus: "INSTOCK"
    },
    {
      image: "https://primefaces.org/cdn/primeng/images/demo/product/bamboo-watch.jpg",
      name: "Bamboo Watch",
      price: 65,
      inventoryStatus: "INSTOCK"
    },
    {
      image: "https://primefaces.org/cdn/primeng/images/demo/product/bamboo-watch.jpg",
      name: "Bamboo Watch",
      price: 65,
      inventoryStatus: "INSTOCK"
    },
    {
      image: "https://primefaces.org/cdn/primeng/images/demo/product/bamboo-watch.jpg",
      name: "Bamboo Watch",
      price: 65,
      inventoryStatus: "INSTOCK"
    },
    {
      image: "https://primefaces.org/cdn/primeng/images/demo/product/bamboo-watch.jpg",
      name: "Bamboo Watch",
      price: 65,
      inventoryStatus: "INSTOCK"
    },
    {
      image: "https://primefaces.org/cdn/primeng/images/demo/product/bamboo-watch.jpg",
      name: "Bamboo Watch",
      price: 65,
      inventoryStatus: "INSTOCK"
    }
  ];

  responsiveOptions: any[] | undefined;

  constructor() {
    this.responsiveOptions = [
      {
        breakpoint: '1199px',
        numVisible: 1,
        numScroll: 1
      },
      {
        breakpoint: '991px',
        numVisible: 2,
        numScroll: 1
      },
      {
        breakpoint: '767px',
        numVisible: 1,
        numScroll: 1
      }
    ];
  }

  getSeverity(status: string) {
    switch (status) {
      case 'INSTOCK':
        return 'success';
      case 'LOWSTOCK':
        return 'warning';
      case 'OUTOFSTOCK':
        return 'danger';
      default:
        return "success";
    }
    
  }
}
