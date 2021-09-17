import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PizzasComponent } from './pizzas/pizzas.component';
import { NavBarComponent } from './NavBar/NavBar.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FooterComponent } from './Footer/Footer.component';
import { HomeComponent } from './Home/Home.component';

@NgModule({
  declarations: [				
    AppComponent,
      PizzasComponent,
      PizzasComponent,
      NavBarComponent,
      FooterComponent,
      HomeComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
