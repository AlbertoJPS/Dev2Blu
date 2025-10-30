import { Routes } from '@angular/router';
// Import path uses the folder name 'books', class name is 'BooksComponent' (assuming file is books.ts)
import { BooksComponent } from './pages/books/books';
import { Home } from './pages/home/home';
import { AboutUs } from './pages/about-us/about-us';
// Import path uses the folder name 'book-page', class name is 'BookPage' (assuming file is book-page.ts)
import { BookPage } from './pages/book-page/book-page';
import { CartPage } from './core/components/cart/cart';


export const routes: Routes = [
  { path: 'home', component: Home },
  // Path updated to 'books' and component name is 'BooksComponent'
  { path: 'books', component: BooksComponent },
  {path: 'aboutus', component: AboutUs},
  // Path updated to 'book-page/:id' and component name is 'BookPage'
  {path: 'book-page/:id', component: BookPage},
  {path: 'cart', component: CartPage},
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: '**', redirectTo: 'home', pathMatch: 'full' },
];