import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import {CurrencyPipe} from '@angular/common';
import { BookService } from '../../core/services/book-service';

// Interface atualizada com 'sinopse' e 'capaUrl'
export interface Book {
  id: string;
  titulo: string;
  sinopse: string; // Atualizado de 'texto'
  capaUrl: string; // Atualizado de 'img'
  price: number;
}

@Component({
  selector: 'app-books',
  // Standalone components need to import themselves or be part of a module
  // Adding standalone: true and importing required modules/components
  standalone: true,
  imports: [RouterLink, CurrencyPipe],
  templateUrl: './books.html',
  styleUrls: ['./books.scss']
})
export class BooksComponent implements OnInit {

  public books: Book[] = [];

    constructor(private bookService: BookService) {}

  ngOnInit(): void {
      this.books = this.bookService.getAllBooks();
      console.log('Catálogo de livros carregado:', this.books);
  }
}