import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable,of} from 'rxjs';
import { Product } from './api-test/model/product.model';


const httpOptions ={
  headers:new HttpHeaders({'Content-Type':'Application/json'})
}
const apiUrl = 'https://6594c6441493b011606ace51.mockapi.io/games';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private httpClient:HttpClient) { }

  getAll():Observable<Product[]>{
    return this.httpClient.get<Product[]>(apiUrl).pipe(
    )
  }
}

