import { Component, OnInit } from '@angular/core';
import { Product } from './model/product.model';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-api-test',
  templateUrl: './api-test.component.html',
  styleUrls: ['./api-test.component.css']
})
export class ApiTestComponent implements OnInit {
  product : Product[] =[];
  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.getAll();
  }

  getAll(){
    this.productService.getAll().subscribe((res:any)=>{
      this.product = res
    })
  }
}
