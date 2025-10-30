import { Injectable } from '@angular/core';
// O import da interface Book (o caminho correto é 'books' no plural)
import { Book } from '../../pages/books/books'; 

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private allBooks: Book[] = [
    {
      id: "o-nome-do-vento",
      titulo: "O Nome do Vento",
      sinopse: "A história de Kvothe, desde sua infância como membro de uma trupe de artistas itinerantes, passando pelos anos difíceis que passou como órfão nas ruas de uma cidade grande, até sua chegada na Universidade de magia.",
  capaUrl: "assets/Capa_ONomeDoVento.jpg",
      price: 59.90
    },
    {
      id: "duna",
      titulo: "Duna",
      sinopse: "Em um futuro distante, planetas são governados por casas nobres. Paul Atreides, herdeiro da Casa Atreides, deve se mudar para o planeta deserto Arrakis, a única fonte da especiaria 'melange', a substância mais valiosa do universo.",
  capaUrl: "assets/Capa_Duna.jpg",
      price: 79.90
    },
    {
      id: "o-problema-dos-tres-corpos",
      titulo: "O Problema dos Três Corpos",
      sinopse: "Durante a Revolução Cultural Chinesa, um projeto militar secreto envia sinais para o espaço. Uma civilização alienígena à beira da destruição capta o sinal e planeja invadir a Terra. Diferentes facções se formam, algumas para saudar os invasores e outras para lutar.",
  capaUrl: "assets/Capa_OProblemaDos3Corpos.jpg",
      price: 49.90
    }
  ];

  constructor() { }

  getAllBooks(): Book[] {
    return this.allBooks;
  }

  // Método essencial para a BookPage
  getBookById(id: string): Book | undefined {
    // Procura na lista o livro cujo ID corresponde ao ID da rota
    return this.allBooks.find(book => book.id === id);
  }
}