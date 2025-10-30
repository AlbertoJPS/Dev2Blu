import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Book } from '../books/books';
import {CommonModule, CurrencyPipe} from '@angular/common';
import { BookService } from '../../core/services/book-service'; // Assumindo este novo path
import { Cart } from '../../core/services/cart';

@Component({
  selector: 'app-book-page',
  standalone: true, // Adicionando standalone: true
  imports: [CurrencyPipe, CommonModule],
  templateUrl: './book-page.html',
  styleUrl: './book-page.scss'
})
// 1. Implementa OnInit
export class BookPage implements OnInit { 
  produtoId: string | null = null;

  public book?: Book; 


  constructor(
    private route: ActivatedRoute,
    private bookService: BookService,
    private cartService : Cart
  ) {}
  
  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.produtoId = params.get('id');
    
      if (this.produtoId) { // Simplificando a verificação de null/undefined
        this.book = this.bookService.getBookById(this.produtoId);
        
        if (!this.book) {
          console.error(`Livro com ID ${this.produtoId} não encontrado.`);
        }
      }
    });
  }

  addToCart() {
    if (this.book) {
      this.cartService.addItem(this.book);
      alert(`[Carrinho] Livro ${this.book.titulo} adicionado com sucesso.`); 
    } else {
      alert("Não é possível adicionar ao carrinho: Livro não carregado.");
    }
  }
}