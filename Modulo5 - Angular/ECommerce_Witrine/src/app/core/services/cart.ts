import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Book } from '../../pages/books/books';

@Injectable({
  providedIn: 'root'
})
export class Cart {
  private cartItems = new BehaviorSubject<Array<Book>>([]);

  public addItem(item: Book) : void{
    let cartItems = this.cartItems.getValue();
    cartItems.push(item);
    this.cartItems.next(cartItems);
    console.log(cartItems);
  }

  public cartItemHasChanged() : Observable<Array<Book>> {
    return this.cartItems.asObservable();
  }
}