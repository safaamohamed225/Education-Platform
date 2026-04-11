import { Routes } from '@angular/router';
import { Home } from './components/home/home';
import { Category } from './components/course/category/category';
import { About} from './components/core/about/about';
import { ContactUs } from './components/core/contact-us/contact-us';
import { PlansAndPricing } from './components/plans-and-picing/plans-and-pricing';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: Home ,  data: { animation: 'HomePage' }},
  { path: 'course/category', component: Category },
  
  
  {
    path: 'about-us',
    data: { animation: 'AboutPage' },
    loadComponent: () =>
      import('./components/core/about/about').then(
        (m) => m.About
      ),
  },
  {
    path: 'contact-us',
    loadComponent: () =>
      import('./components/core/contact-us/contact-us').then(
        (m) => m.ContactUs
      ),
  },

  {
    path: 'plans-and-price',
    loadComponent: () =>
      import('./components/plans-and-picing/plans-and-pricing').then(
        (m) => m.PlansAndPricing
      ),
  },
  
  { path: '**', redirectTo: 'home' },
];