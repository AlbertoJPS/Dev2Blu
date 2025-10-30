import { Component, OnInit } from '@angular/core';
import { RouterLink } from "@angular/router";
import { CommonModule } from '@angular/common'; 
import { Cart } from '../../core/services/cart';

@Component({
  selector: 'app-menu',
  standalone: true,
  imports: [RouterLink, CommonModule], // Adicionando CommonModule
  templateUrl: './menu.html',
  styleUrl: './menu.scss'
})
export class Menu implements OnInit {
  // Variável que armazena a contagem de itens no carrinho para o badge.
  cartCount: number = 0;

  constructor(private cartService: Cart) {}

  ngOnInit(): void {
    // Inscreve-se nas mudanças do carrinho para atualizar a contagem em tempo real
    this.cartService.cartItemHasChanged().subscribe(items => {
      this.cartCount = items.length;
    });
  }
}