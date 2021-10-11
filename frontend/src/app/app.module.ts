import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClient, HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './NavBar/NavBar.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FooterComponent } from './Footer/Footer.component';
import { PizzaComponent } from './Pizza/Pizza.component';
import { HomeComponent } from './Home/Home.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { ComprasComponent } from './Compras/Compras.component';
import { PizzaService } from './Services/pizza.service';

@NgModule({
  declarations: [							
    AppComponent,
      NavBarComponent,
      FooterComponent,
      PizzaComponent,
      HomeComponent,
      ComprasComponent
   ],
  imports: [
    ReactiveFormsModule,
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
    ModalModule.forRoot(),
  ],
  providers: [HttpClient, HttpClientModule, PizzaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
