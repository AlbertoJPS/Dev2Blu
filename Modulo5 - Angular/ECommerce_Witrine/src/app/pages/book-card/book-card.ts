import { Component, EventEmitter, Input, Output } from '@angular/core';
import {Book} from '../books/books'

@Component({
  selector: 'app-book-card',
  imports: [],
  templateUrl: './book-card.html',
  styleUrl: './book-card.scss'
})
export class BookCard {
  @Input()
  public book?: Book;

  @Output()
  public onBuyClicked = new EventEmitter<string>();

  onClick() {
    this.onBuyClicked.emit(this.book?.titulo);
  }
}