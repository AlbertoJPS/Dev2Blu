
import { Component } from '@angular/core';
import { Book } from '../../../pages/books/books';
import { Cart } from '../../services/cart';
import { CommonModule, CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-cart',
 
  imports: [CommonModule, CurrencyPipe],
  standalone: true, 
  templateUrl: './cart.html',
  styleUrl: './cart.scss'
})

export class CartPage {
  protected books : Book[] = [];

  constructor(private cartService : Cart) {
    this.cartService.cartItemHasChanged().subscribe((books: Array<Book>) => {
      this.books = books;
    })
  }
}