import { Component } from '@angular/core';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-blog',
  standalone: true,
  imports: [],
  templateUrl: './blog.component.html',
  styleUrl: './blog.component.css'
})
export class BlogComponent {
constructor(private product: ProductService){}
}
