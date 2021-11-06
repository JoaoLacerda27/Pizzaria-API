import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ComprasComponent } from './Compras/Compras.component';
import { HomeComponent } from './Home/Home.component';
import { PizzaComponent } from './Pizza/Pizza.component';

const routes: Routes = [
  {path: '', redirectTo: 'home', pathMatch: 'full'},
  {path: 'pizzas', component: PizzaComponent},
  {path: 'home', component: HomeComponent},
  {path: 'compras', component: ComprasComponent},
  {path: 'compras/:id', component: ComprasComponent}
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
